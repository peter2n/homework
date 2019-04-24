using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
//using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
using SelectPdf;



namespace INK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void lblSourcePDF_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            this.lblSourcePDF.Text = fileNames[0];
        }

        private void lblSourcePDF_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void btnSelectPdfCreatePage_Click(object sender, EventArgs e)
        {


                // create a new pdf document
                PdfDocument doc = new PdfDocument();

                // add a new page to the document
                PdfPage page = doc.AddPage();

                // create a new pdf font
                PdfFont font = doc.AddFont(PdfStandardFont.Helvetica);
                font.Size = 20;

                // create a new text element and add it to the page
                PdfTextElement text = new PdfTextElement(50, 50, "Hello world!", font);
                page.Add(text);

            // save pdf document
            doc.Save("D:\\Rabota2019\\FTP-Сс\\script\\Sample.pdf");

            //close pdf document
            doc.Close();





        }

        private void btnPdfProperties_Click(object sender, EventArgs e)
        {
            // create a new pdf document
            PdfDocument doc = new PdfDocument();

            // add a new page to the document
            PdfPage page = doc.AddPage();

            // create a new pdf font
            PdfFont font = doc.AddFont(PdfStandardFont.Helvetica);
            font.Size = 20;

            // create a new text element and add it to the page
            PdfTextElement text = new PdfTextElement(50, 50,
                "Select.Pdf for .NET - Document Properties Sample", font);
            page.Add(text);

            // set the document properties
            doc.DocumentInformation.Title = "Select.Pdf for .NET Sample";
            doc.DocumentInformation.Author = "Select.Pdf Samples";
            doc.DocumentInformation.Subject = "Select.Pdf Library Samples";
            doc.DocumentInformation.Keywords = "pdf library, sample code";
            doc.DocumentInformation.CreationDate = DateTime.Now;

            // save pdf document
            doc.Save("D:\\Rabota2019\\FTP-Сс\\script\\Sample.pdf");

            // close pdf document
            doc.Close();


        }

        private void btnPdfSize_Click(object sender, EventArgs e)
        {
            // create a new pdf document
            PdfDocument doc = new PdfDocument();

            // create a new pdf font
            PdfFont font = doc.AddFont(PdfStandardFont.Helvetica);
            font.Size = 18;

            // add a new page to the document 
            // (with specific page size, margins and orientation)
            PdfPage page = doc.AddPage(PdfCustomPageSize.A4,
                new PdfMargins(0f), PdfPageOrientation.Landscape);

            // create a new text element and add it to the page
            PdfTextElement text = new PdfTextElement(10, 10, "PETER \nnot \nUNICODE", font);
            page.Add(text);





            // save pdf document
            doc.Save("D:\\Rabota2019\\FTP-Сс\\script\\Sample.pdf");

            // close pdf document
            doc.Close();



        }

        private void btnPdfLinks_Click(object sender, EventArgs e)
        {
            // create a new pdf document
            PdfDocument doc = new PdfDocument();

            // add a new page to the document
            PdfPage page1 = doc.AddPage();

            // add a second page to the document
            PdfPage page2 = doc.AddPage();

            // define a rendering result object
            PdfRenderingResult result;

            // create a new pdf font
            PdfFont font = doc.AddFont(PdfStandardFont.Helvetica);
            font.Size = 14;
            font.IsUnderline = true;

            // create a new text element and add it to the first page
            PdfTextElement text1 = new PdfTextElement(0, 0,
                "First page (no link on this text)", font);
            page1.Add(text1);

            // create a new text element and add it to the second page
            PdfTextElement text2 = new PdfTextElement(0, 0,
                "Second page (no link on this text)", font);
            page2.Add(text2);

            // create external link in 2 steps

            // 1 - create the link text
            PdfTextElement linkText1 = new PdfTextElement(0, 50,
                "External link (click to go to selectpdf.com)", font);
            result = page1.Add(linkText1);

            // 2 - add the link using the text rendering rectangle
            PdfExternalLinkElement extLink1 = new PdfExternalLinkElement(
                result.PdfPageLastRectangle, "http://selectpdf.com");
            page1.Add(extLink1);

            // create internal link in 2 steps

            // 1 - create the link text
            PdfTextElement linkText2 = new PdfTextElement(0, 100,
                "Internal link (click to go to the second page)", font);
            result = page1.Add(linkText2);

            // 2 - add the link using the text rendering rectangle
            PdfInternalLinkElement intLink1 = new PdfInternalLinkElement(
                result.PdfPageLastRectangle, new PdfDestination(page2));
            page1.Add(intLink1);

            // save pdf document
            doc.Save("D:\\Rabota2019\\FTP-Сс\\script\\Sample2.pdf");

            // close pdf document
            doc.Close();




        }

        private void btnModifiPdf_Click(object sender, EventArgs e)
        {
            // the test file
            string filePdf = "D:\\Rabota2019\\FTP-Сс\\script\\2984 Ewofarma Shelf Taker.pdf";

            // settings
            string pdf_page_size = "A2";//
            PdfPageSize pdfPageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                pdf_page_size, true);

            PdfCustomPageSize pageSize = PdfCustomPageSize.A4;
            switch (pdfPageSize)
            {
                case PdfPageSize.A1:
                    pageSize = PdfCustomPageSize.A1;
                    break;
                case PdfPageSize.A2:
                    pageSize = PdfCustomPageSize.A2;
                    break;
                case PdfPageSize.A3:
                    pageSize = PdfCustomPageSize.A3;
                    break;
                case PdfPageSize.A5:
                    pageSize = PdfCustomPageSize.A5;
                    break;
                case PdfPageSize.Letter:
                    pageSize = PdfCustomPageSize.Letter;
                    break;
                case PdfPageSize.HalfLetter:
                    pageSize = PdfCustomPageSize.HalfLetter;
                    break;
                case PdfPageSize.Ledger:
                    pageSize = PdfCustomPageSize.Ledger;
                    break;
                case PdfPageSize.Legal:
                    pageSize = PdfCustomPageSize.Legal;
                    break;
            }

            string pdf_orientation = "Landscape";//
            PdfPageOrientation pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int topMargin = 0;
            try
            {
                topMargin = 3;//
            }
            catch { }

            int rightMargin = 0;
            try
            {
                rightMargin = 3;//
            }
            catch { }

            int bottomMargin = 0;
            try
            {
                bottomMargin = 3;//
            }
            catch { }

            int leftMargin = 0;
            try
            {
                leftMargin = 3;//
            }
            catch { }

            string horizontal_align = "Right";//Left,Right
            PdfHorizontalAlign pdfHorizontalAlign =
                (PdfHorizontalAlign)Enum.Parse(typeof(PdfHorizontalAlign),
                horizontal_align, true);

            string vertical_align = "Bottom";//Top,Bottom
            PdfVerticalAlign pdfVerticalAlign =
                (PdfVerticalAlign)Enum.Parse(typeof(PdfVerticalAlign),
                vertical_align, true);

            // resize the content
            PdfResizeManager resizer = new PdfResizeManager();
            resizer.Load(filePdf);

            resizer.PageMargins = new PdfMargins(
                leftMargin, rightMargin, topMargin, bottomMargin);
            resizer.PageSize = pageSize;
            resizer.PageOrientation = pdfOrientation;
            resizer.AllowScale = true;//
            resizer.KeepAspectRatio = true;//
            resizer.HorizontalAlign = pdfHorizontalAlign;
            resizer.VerticalAlign = pdfVerticalAlign;

            // save pdf document
            resizer.Save("D:\\Rabota2019\\FTP-Сс\\script\\Modify.pdf");//

            // close pdf document
            resizer.Close();





        }
    }
}
