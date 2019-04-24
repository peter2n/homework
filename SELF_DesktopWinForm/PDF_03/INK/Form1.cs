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


        private void btnStep1_Click(object sender, EventArgs e)
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
            resizer.Save("D:\\Rabota2019\\FTP-Сс\\script\\Step1.pdf");//

            // close pdf document
            resizer.Close();



        }

        private void btnStep2_Click(object sender, EventArgs e)
        {

            // the test file
            string filePdf = "D:\\Rabota2019\\FTP-Сс\\script\\Step1.pdf";

            // settings
            string pdf_page_size = "A1";//
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

            string pdf_orientation = "Portrait";//
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
            resizer.Save("D:\\Rabota2019\\FTP-Сс\\script\\Step2.pdf");//

            // close pdf document
            resizer.Close();



        }
    }
}
