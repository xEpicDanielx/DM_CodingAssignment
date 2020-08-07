using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalandromeAssignment
{
    class Paragraph : SentenceStructure
    {
        List<string> sList = new List<string>();
        public Dictionary<String, int> individualWordsDictionary = new Dictionary<String,int>();
        public int palSentences;
        public int palWords;


        public void developTheParagraph(string paragraphText)
        {
            string pText = paragraphText.ToLower();

            //first we get the words and sentences.
            individualWordsDictionary = getWordDictionary(pText);
            sList = getSList(pText);

            //check if palandrome
            foreach (KeyValuePair<string, int> word in individualWordsDictionary)
            {
                if (checkIfPalendrome(word.Key))
                {
                    palWords++;
                }
            }
            foreach (String sentence in sList)
            {
                if (checkIfPalendrome(sentence))
                {
                    palSentences++;
                }
            }

        }

        public List<string> searchForWords(string letter)
        {
            letter = letter.ToLower(); 
            Console.WriteLine("SEARCHING");
            List<string> matches = new List<string>();

            foreach (KeyValuePair<string, int> word in individualWordsDictionary)
            {
                if (word.Key.Contains(letter))
                    matches.Add(word.Key); 
            }
            return matches; 
        }
        
        bool checkIfPalendrome(string txt)
        {
            //making sure text isnt whitespace.
            if (txt != " " || txt != "")
            {
                //send everything to char aray then reverse it and see if it matches. 
                char[] checker = txt.ToCharArray();
                Array.Reverse(checker);
                string reversed = new string(checker);

                bool pal = txt.Equals(reversed, StringComparison.OrdinalIgnoreCase);

                if (pal)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //if its nothing then just return false.
            else
                return false;
        }
    }
}

