using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalandromeAssignment
{
    public partial class Form1 : Form
    {
        public string paragraphText; 

        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Btn_Click(object sender, EventArgs e)
        {
            paragraphText = paragraph_TB.Text;

            initParagraph();
        }

        void initParagraph()
        {
            Paragraph paragraph = new Paragraph();
            if (paragraphText != null)
            {
                paragraph_Label.Text = paragraphText; 
                paragraph.developTheParagraph(paragraphText);
            }
            else
                paragraph_Label.Text = "Please enter a paragraph";
            /*split words*/
        }
    }
}
