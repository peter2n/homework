using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetterToASCII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtIN_TextChanged(object sender, EventArgs e)
        {
            string input = txtIN1.Text;
            List<char> inputList = input.ToList();
            List<int> outList = inputList.Select(x => (int)(x)).ToList();
            lblOut1.Text = String.Join(" ", outList);
        }

        private void txtIN2_TextChanged(object sender, EventArgs e)
        {
            string input = txtIN2.Text;
            List<char> inputList = input.ToList();
            List<int> outList = inputList.Select(x => (int)(x)).ToList();
            lblOut2.Text = String.Join(" ", outList);
        }
    }
}
