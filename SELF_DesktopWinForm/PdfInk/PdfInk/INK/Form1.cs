using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
