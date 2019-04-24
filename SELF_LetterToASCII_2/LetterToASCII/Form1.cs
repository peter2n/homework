using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

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

            List<char> inputListChars = input.ToList();
            List<int> outListInt = inputListChars.Select(x => (int)(x)).ToList();
            List<string> outListString = outListInt.Select(x => $"{x,6}").ToList();
            lblOut1.Text = String.Join(".", outListString);

            List<string> lblListString = inputListChars.Select(x => $"{x,6}").ToList();
            string lblText =string.Join(".", lblListString);
            lbl1.Text = lblText;
        }

        private void txtIN2_TextChanged(object sender, EventArgs e)
        {
            string input = txtIN2.Text;
            List<char> inputList = input.ToList();
            List<int> outList = inputList.Select(x => (int)(x)).ToList();
            lblOut2.Text = String.Join(" ", outList);
        }


        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            int code = 0;
            if (int.TryParse(txtCode.Text, out code)&&code>31&&code<65537)
            {
                char symbol = (char)code;
                lblSymbol.Text = symbol.ToString();
                lblRange.Text = CharUnicodeInfo.GetUnicodeCategory(symbol).ToString() ;
            }
            else
            {
                lblSymbol.Text = "";
            }
        }
    }
}
