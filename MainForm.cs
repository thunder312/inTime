/*
 * Created by SharpDevelop.
 * User: der
 * Date: 08.07.2015
 * Time: 15:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace inTime
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	
	public partial class MainForm : Form
	{
		
		String lastLoaded = "";
		
		public MainForm()
		{		
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		void AddBookClick(object sender, EventArgs e)
		{
				
			// Add book to listview
			string[] row = { countPages.Text, countRepeats.Text, diffRatio.Text };
			
			//Already exists?
			bool alreadyExists = false;
			foreach(ListViewItem itemRow in lvBookList.Items)
			{
				if(itemRow.SubItems[0].Text.Equals(bookName.Text))
				{
				   	itemRow.SubItems[1].Text = countPages.Text;
				   	itemRow.SubItems[2].Text = countRepeats.Text;
				   	itemRow.SubItems[3].Text = diffRatio.Text;
				   	alreadyExists = true;
				   	break;
				}
				   if(alreadyExists)
				   	break;
			}
			
			if(!alreadyExists)
				lvBookList.Items.Add(bookName.Text).SubItems.AddRange(row);
			
			bookName.Text = "";
			countPages.Text = "1";
			countRepeats.Text = "1";
			diffRatio.Text = "1";
			
		}
	
	void CalculateClick(object sender, EventArgs e)
	{
		
		learnPlan.Clear();
		
		float grandTotalPages = 0;
		float weightedGrandTotalPages = 0;
		int days = 1;
		float pagesPerDay = 0;
		float weightedPagesPerDay = 0;
		
		// calculate pages
		foreach(ListViewItem itemRow in lvBookList.Items){
			grandTotalPages 		+= (int.Parse(itemRow.SubItems[1].Text) * (int.Parse(itemRow.SubItems[2].Text)));
			weightedGrandTotalPages += (float.Parse(itemRow.SubItems[1].Text) * (float.Parse(itemRow.SubItems[2].Text)) * (float.Parse(itemRow.SubItems[3].Text)));
		}
		
		// calculate days
		DateTime d1 = calEnd.SelectionRange.Start;
		DateTime d2 = calStart.SelectionRange.Start;
		days = (d1 - d2).Days;
		
		int nettoDays = days - int.Parse(freeDays.Text);
		pagesPerDay = grandTotalPages / nettoDays;
		weightedPagesPerDay = weightedGrandTotalPages / nettoDays;
		
		// learnplan head
		
		learnPlan.Text += "Lernplan vom " + d2.ToString("dd.MM.yyyy") + " bis zum " + d1.ToString("dd.MM.yyyy") + System.Environment.NewLine;
		
		learnPlan.Text += System.Environment.NewLine + "Seiten komplett: " + Math.Ceiling(grandTotalPages).ToString()  + "   gewichted: " + Math.Ceiling(weightedGrandTotalPages).ToString();
		learnPlan.Text += System.Environment.NewLine + "LernTage = " + days.ToString() + " - " + freeDays.Text.ToString() + " = " + nettoDays.ToString();
		learnPlan.Text += System.Environment.NewLine + "Seiten pro Tag: " + Math.Ceiling(pagesPerDay).ToString() + "   gewichted: " + Math.Ceiling(weightedPagesPerDay).ToString();
		
		learnPlan.Text += System.Environment.NewLine + System.Environment.NewLine + "Aufteilung der Tage auf die Bücher:";
		learnPlan.Text += System.Environment.NewLine;
		
		double sumDaysUnweighted = 0;
		double sumDaysWeighted = 0;
		
		// all given books
		
		foreach(ListViewItem itemRow in lvBookList.Items){
			double daysPerBook = int.Parse(itemRow.SubItems[1].Text) / Math.Round(pagesPerDay, 0);
			double weightedDaysPerBook = int.Parse(itemRow.SubItems[1].Text) / Math.Round(weightedPagesPerDay, 0);
			double totalDays = daysPerBook * int.Parse(itemRow.SubItems[2].Text);
			double weightedTotal = weightedDaysPerBook * int.Parse(itemRow.SubItems[2].Text);
			double ratio = double.Parse(itemRow.SubItems[3].Text);
			double weightedTotalDays = weightedTotal * ratio;
			
			sumDaysUnweighted += totalDays;
			sumDaysWeighted += weightedTotalDays;
			
			
			learnPlan.Text += System.Environment.NewLine + "Buch: " +  itemRow.SubItems[0].Text;
			learnPlan.Text += System.Environment.NewLine +  "   " + Math.Round(daysPerBook, 2)  + " Tage pro Wiederholung";
			learnPlan.Text += System.Environment.NewLine +	"   insgesamt " + Math.Round(totalDays, 2) + " Tage";
			learnPlan.Text += System.Environment.NewLine +  "   gewichted: " + Math.Round(weightedTotalDays, 2) + " Tage" + System.Environment.NewLine;
		}
		
		learnPlan.Text += System.Environment.NewLine +	"insgesamt: " + Math.Round(sumDaysUnweighted, 2) + " Tage";
		learnPlan.Text += System.Environment.NewLine + "gewichted: " + Math.Round(sumDaysWeighted, 2);
		
	}
	
	void DeleteClick(object sender, EventArgs e)
	{
		if(lvBookList.SelectedItems.Count == 0)
			return;
		
		lvBookList.SelectedItems[0].Remove();
	}
	
	void PlanName_PressEnter(object sender, KeyEventArgs e)
	{
		if(e.KeyCode == Keys.Enter)
			LoadClick(sender, e);
	}
	
	void BookName_PressEnter(object sender, KeyEventArgs e)
	{
		if(e.KeyCode == Keys.Enter)
			AddBookClick(sender, e);
	}
	
	void ExportClick(object sender, EventArgs e)
	{
		// new pdf
		Document doc = new Document(iTextSharp.text.PageSize.A4, 50, 50, 50, 50);
		
		PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@".\" + planName.Text +".pdf", FileMode.Create));
		writer.SetFullCompression();
		writer.CloseStream = true;
		
		doc.Open();
		doc.NewPage();
		
		// fonts
		iTextSharp.text.Font title = iTextSharp.text.FontFactory.GetFont("Arial", 18);
		iTextSharp.text.Font logo = iTextSharp.text.FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.ITALIC);
		iTextSharp.text.Font standard = iTextSharp.text.FontFactory.GetFont("Arial", 10);
		iTextSharp.text.Font small = iTextSharp.text.FontFactory.GetFont("Arial", 8);

		iTextSharp.text.Font standardbold = iTextSharp.text.FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD);
		iTextSharp.text.Font standardUnderline = iTextSharp.text.FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.UNDERLINE);
		iTextSharp.text.Font smallitalic = iTextSharp.text.FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.ITALIC);
		
		// Calculation
		float grandTotalPages = 0;
		float weightedGrandTotalPages = 0;
		int days = 1;
		float pagesPerDay = 0;
		float weightedPagesPerDay = 0;
		
		// calculate pages
		foreach(ListViewItem itemRow in lvBookList.Items){
			grandTotalPages 		+= (int.Parse(itemRow.SubItems[1].Text) * (int.Parse(itemRow.SubItems[2].Text)));
			weightedGrandTotalPages += (float.Parse(itemRow.SubItems[1].Text) * (float.Parse(itemRow.SubItems[2].Text)) * (float.Parse(itemRow.SubItems[3].Text)));
		}
		
		// calculate days
		DateTime d1 = calEnd.SelectionRange.Start;
		DateTime d2 = calStart.SelectionRange.Start;
		days = (d1 - d2).Days;
		
		int nettoDays = days - int.Parse(freeDays.Text);
		pagesPerDay = grandTotalPages / nettoDays;
		weightedPagesPerDay = weightedGrandTotalPages / nettoDays;
		
		// learnplan head
		
		Paragraph headline = CreateParagraph("Lernplan '" + planName.Text +  "'" , title);
		doc.Add(headline);
		
		Paragraph date = CreateParagraph("vom " + d2.ToString("dd.MM.yyyy") + " bis zum " + d1.ToString("dd.MM.yyyy"), standard);
		doc.Add(date);
		
		doc.Add(AddEmptyParagraph());
		doc.Add(AddEmptyParagraph());
		
		doc.Add(CreateParagraph("Seiten komplett: " + Math.Ceiling(grandTotalPages).ToString()  + "   gewichted: " + Math.Ceiling(weightedGrandTotalPages).ToString(), standardbold));
		doc.Add(CreateParagraph("LernTage = " + days.ToString() + " - " + freeDays.Text.ToString() + " = " + nettoDays.ToString(), standardbold));
		doc.Add(CreateParagraph("Seiten pro Tag: " + Math.Ceiling(pagesPerDay).ToString() + "   gewichted: " + Math.Ceiling(weightedPagesPerDay).ToString(), standardbold));
		doc.Add(AddEmptyParagraph());
		doc.Add(CreateParagraph("Aufteilung der Tage auf die Bücher:", standardUnderline));
		doc.Add(AddEmptyParagraph());
		
		double sumDaysUnweighted = 0;
		double sumDaysWeighted = 0;
		
		// all given books
		
		foreach(ListViewItem itemRow in lvBookList.Items){
			double daysPerBook = int.Parse(itemRow.SubItems[1].Text) / Math.Round(pagesPerDay, 0);
			double weightedDaysPerBook = int.Parse(itemRow.SubItems[1].Text) / Math.Round(weightedPagesPerDay, 0);
			double totalDays = daysPerBook * int.Parse(itemRow.SubItems[2].Text);
			double weightedTotal = weightedDaysPerBook * int.Parse(itemRow.SubItems[2].Text);
			double ratio = double.Parse(itemRow.SubItems[3].Text);
			double weightedTotalDays = weightedTotal * ratio;
			
			sumDaysUnweighted += totalDays;
			sumDaysWeighted += weightedTotalDays;
			
			
			doc.Add(CreateParagraph("Buch: " +  itemRow.SubItems[0].Text + 
			                        " ( S: " + itemRow.SubItems[1].Text +
			                        " / W: "   + itemRow.SubItems[2].Text +
									" / H: " + itemRow.SubItems[3].Text + ")"
									, standardbold));
			
			doc.Add(CreateParagraph("   " + Math.Round(daysPerBook, 2)  + " Tage pro Wiederholung", standard));
			doc.Add(CreateParagraph("   insgesamt " + Math.Round(totalDays, 2) + " Tage", standard));
			doc.Add(CreateParagraph("   gewichted: " + Math.Round(weightedTotalDays, 2) + " Tage", standard));
			doc.Add(AddEmptyParagraph());
		}
		
		doc.Add(AddEmptyParagraph());
		
		doc.Add(CreateParagraph("insgesamt: " + Math.Round(sumDaysUnweighted, 2) + " Tage", standardbold));
		doc.Add(CreateParagraph("gewichted: " + Math.Round(sumDaysWeighted, 2), standardbold));
		
		doc.Add(AddEmptyParagraph());
		doc.Add(AddEmptyParagraph());
		
		// PDF create Date/Time
		DateTime createdOnLocal = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Local);
		
		Paragraph version = new Paragraph(Application.ProductName + " Version: " +  Application.ProductVersion, smallitalic);
		version.Alignment = Element.ALIGN_RIGHT;
		doc.Add(version);
		
		Paragraph copyright= new Paragraph("Programmiert von: Daniel Ertl (daniel.ertl@email.de) ", smallitalic);
		copyright.Alignment = Element.ALIGN_RIGHT;
		doc.Add(copyright);
		
		Paragraph dedicated = new Paragraph("Gewidmet: Marion Berer ", smallitalic);
		dedicated.Alignment = Element.ALIGN_RIGHT;
		doc.Add(dedicated);
		
		Paragraph freeware = new Paragraph("Dieses Programm ist Freeware und somit gratis.", smallitalic);
		freeware.Alignment = Element.ALIGN_RIGHT;
		doc.Add(freeware);
		
		doc.AddTitle(planName.Text);
		doc.AddCreator("inTime; Copyright Daniel Ertl (daniel.ertl@email.de)");
		
		doc.Close();
		
		//open pdf
		System.Diagnostics.Process.Start(@".\" + planName.Text +".pdf");
		
	}
	
	public static Paragraph AddEmptyParagraph()
	{
		iTextSharp.text.Font standard = iTextSharp.text.FontFactory.GetFont("Arial", 10);

		return CreateParagraph(Environment.NewLine, standard);
	}
	
	public static Paragraph CreateParagraph(string text, iTextSharp.text.Font font)
	{
		return new iTextSharp.text.Paragraph(new iTextSharp.text.Chunk(text, font));
	}
	
	void LvBookListLoadBook(object sender, EventArgs e)
	{
		ListViewItem selectedItem = lvBookList.SelectedItems[0];
		bookName.Text = selectedItem.SubItems[0].Text;
		countPages.Value = int.Parse(selectedItem.SubItems[1].Text);
		countRepeats.Value = int.Parse(selectedItem.SubItems[2].Text);
		diffRatio.Value = decimal.Parse(selectedItem.SubItems[3].Text);
	}
	
	void SavePlanClick(object sender, EventArgs e)
	{
		XmlDocument doc = new XmlDocument();
		XmlNode root, book, daysOff, startDate, endDate;
		XmlAttribute pages, repeats, ratio;
		
		// Learnplan Name
		root = doc.CreateElement(planName.Text);
		doc.AppendChild(root);
		
		// Books
		foreach(ListViewItem itemRow in lvBookList.Items){
			book = doc.CreateElement("Book");
			book.InnerText = itemRow.SubItems[0].Text;
			
			// Attributes
			pages = doc.CreateAttribute("pages");
			pages.InnerText = itemRow.SubItems[1].Text;
			book.Attributes.Append(pages);
			
			repeats = doc.CreateAttribute("repeats");
			repeats.InnerText = itemRow.SubItems[2].Text;
			book.Attributes.Append(repeats);
			
			ratio = doc.CreateAttribute("ratio");
			ratio.InnerText = itemRow.SubItems[3].Text;
			book.Attributes.Append(ratio);
			
			root.AppendChild(book);
		}
		
		// days off value
		daysOff = doc.CreateElement("DaysOff");
		daysOff.InnerText = freeDays.Text;
		root.AppendChild(daysOff);
		
		// start date
		startDate = doc.CreateElement("StartDate");
		startDate.InnerText = calStart.SelectionRange.Start.ToString();
		root.AppendChild(startDate);
		
		// end date
		endDate = doc.CreateElement("EndDate");
		endDate.InnerText = calEnd.SelectionRange.Start.ToString();
		root.AppendChild(endDate);
		
		// save document
		String filePath = @".\" + planName.Text +".xml";
		if(File.Exists(filePath))
		{
			File.Delete(filePath);
		}
		doc.Save(@".\" + planName.Text +".xml");
	}
	
	void LoadClick(object sender, EventArgs e)
	{
		if(planName.Text != "" && planName.Text != lastLoaded)
		{
			// Don't load it twice!!
			lastLoaded = planName.Text;
			
			if(!File.Exists(@".\" + planName.Text +".xml"))
			{
				planName.Text += " - nicht gefunden.";
				return;
			}			
			
			// load document
			XmlReader reader = XmlReader.Create(@".\" + planName.Text +".xml");
			
			
			while (reader.Read())
			{
				if (reader.NodeType == XmlNodeType.Element
				    && reader.Name == planName.Text)
				{
					while (reader.NodeType != XmlNodeType.EndElement)
					{
						reader.Read();
						// Book
						while (reader.Name == "Book")
						{
							if(reader.NodeType != XmlNodeType.EndElement)
							{
								// Add book to listview
								string[] row = { reader.GetAttribute(0), reader.GetAttribute(1), reader.GetAttribute(2) };
								reader.Read();
								if(reader.NodeType == XmlNodeType.Text)
									lvBookList.Items.Add(reader.Value).SubItems.AddRange(row);
							}
							reader.Read();
						} // end while book
						
						
						// DaysOff
						if (reader.NodeType != XmlNodeType.EndElement && reader.Name == "DaysOff")
						{
							reader.Read();
							freeDays.Value = Int32.Parse(reader.Value);
						} // end DaysOff */
						
					} // end while
					
					while(reader.Name != "StartDate")
					{
						reader.Read();
					}
					
					if(reader.NodeType != XmlNodeType.EndElement && reader.Name == "StartDate")
					{
						reader.Read();
						DateTime start = DateTime.ParseExact(reader.Value, "dd.MM.yyyy HH:mm:ss",
						                                     System.Globalization.CultureInfo.InvariantCulture);
						calStart.SetDate(start);
					}
					
					while(reader.Name != "EndDate")
					{
						reader.Read();
					}
					
					if(reader.NodeType != XmlNodeType.EndElement && reader.Name == "EndDate")
					{
						reader.Read();
						DateTime end = DateTime.ParseExact(reader.Value, "dd.MM.yyyy HH:mm:ss",
						                                   System.Globalization.CultureInfo.InvariantCulture);
						calEnd.SetDate(end);
					}
					reader.Close();
					
				} // end if reader.name == planName.Text
				
			} //end while
			
		} // end if plan name not empty
	} // load click
} // MainForm
} //namepace