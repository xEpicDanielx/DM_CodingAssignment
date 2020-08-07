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

        Paragraph currentParagraph; 
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
            currentParagraph = new Paragraph();
            if (paragraphText != null)
            {
                paragraph_Label.Text = paragraphText;
                currentParagraph.developTheParagraph(paragraphText);
            }
            else
                paragraph_Label.Text = "Please enter a paragraph";

            updateDisplay();
            /*split words*/
        }

        void updateDisplay()
        {
            pSentenceCount_Label.Text = currentParagraph.palSentences.ToString();
            pWordCount_Label.Text = currentParagraph.palWords.ToString();
            foreach(KeyValuePair<string,int> word in currentParagraph.individualWordsDictionary)
            {
                ListViewItem item = new ListViewItem(word.Key);
                item.SubItems.Add(word.Value.ToString());
                wordDisplay_LB.Items.Add(item);
            }
            
           
        }
        
    }
}
