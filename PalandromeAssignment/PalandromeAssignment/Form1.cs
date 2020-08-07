﻿using System;
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
        //paragraph we are analizing
        Paragraph currentParagraph;

        //text of paragraph. 
        public string paragraphText;

        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Btn_Click(object sender, EventArgs e)
        {
            //first we clear all displays
            clearDisplays();
            //this checks if user just entered a space or a empty paragraph.
            paragraphText = paragraph_TB.Text.Trim();
            //if its not 0 then we can create a paragraph.
            if(paragraphText.Length != 0)
            {
                initParagraph();
            }
            else
            {
                //tells user we need to add a paragraph.
                InstructUser(); 
            }
        }

        //Create a new paragaph based upon the input of the user.
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
        }

        private void letterSrch_BTN_Click(object sender, EventArgs e)
        {
            individualWords_View.Clear(); 
            if (letterSearch_TB.Text != null && letterSearch_TB.Text != " ")
            {
                List<string> matchedWords = currentParagraph.searchForWords(letterSearch_TB.Text);
                foreach (string word in matchedWords)
                {
                    individualWords_View.Items.Add(word);
                }
            }
            individualWords_View.Sorting = SortOrder.Ascending; 
        }

        #region /*----------------------------------------Display Functions-------------------------------------*/
        void clearDisplays()
        {
            paragraph_Label.Text = "";
            individualWords_View.Clear();
            pSentenceCount_Label.Text = "0";
            pWordCount_Label.Text = "0";

            for (int i = 0; i < wordDisplay_LB.Items.Count; i++)
            {
                wordDisplay_LB.Items.RemoveAt(i);
            }

        }

        void updateDisplay()
        {
            pSentenceCount_Label.Text = currentParagraph.palSentences.ToString();
            pWordCount_Label.Text = currentParagraph.palWords.ToString();
            for (int i = 0; i < wordDisplay_LB.Items.Count; i++)
            {
                wordDisplay_LB.Items.RemoveAt(i);
            }
            foreach (KeyValuePair<string, int> word in currentParagraph.individualWordsDictionary)
            {
                ListViewItem item = new ListViewItem(word.Key);
                item.SubItems.Add(word.Value.ToString());
                wordDisplay_LB.Items.Add(item);
            }


        }

        void InstructUser()
        {
            paragraph_Label.Text = "Cannot enter a blank paragraph.";
        }

        #endregion
    }
}
