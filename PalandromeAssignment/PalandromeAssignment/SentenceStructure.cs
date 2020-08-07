using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalandromeAssignment
{
    class SentenceStructure
    {
        //What delimiterChars
        char[] delimiterChars = { '.', '!', '?' };

        //splits words of the paragraph text and then returns the word dictionary.
        public Dictionary<string,int> getWordDictionary(string paragraphText)
        {
            var sb = new StringBuilder();
            string[] individualWords;

            Dictionary<String, int> individualWordsDictionary = new Dictionary<String, int>(); 
            
            //split from spaces to get individual words
            individualWords = paragraphText.Split(' ');

            for (int i = 0; i < individualWords.Length; i++)
            {
                //get rid of all punctuation
                foreach (char c in individualWords[i])
                {
                    if (!char.IsPunctuation(c))
                        sb.Append(c);
                }

                //thereis a better way to do this.
                individualWords[i] = sb.ToString();

                // if dictionary already has word, just plus1 to it.
                if (individualWordsDictionary.ContainsKey(individualWords[i]))
                {
                    individualWordsDictionary[individualWords[i]] += 1;
                }
                else
                {
                    individualWordsDictionary.Add(individualWords[i], 1);
                }

                sb = new StringBuilder();
            }


            return individualWordsDictionary; 
        }

        //splits into sentences
        public List<string> getSList(string pText)
        {
            List<string> sentences = new List<string>();
            //split by sentance
            string[] words = pText.Split(delimiterChars);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < words.Length - 1; i++)
            {
                //get rid of all punctuation
                foreach (char c in words[i])
                {
                    //make sure there is no whitespace or punctuation. 
                    if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
                    {
                        //adds char if its not a punctuation or space
                        sb.Append(c);
                    }
                }

                //thereis a better way to do this.
                words[i] = sb.ToString();
                sentences.Add(words[i]);
                sb = new StringBuilder();
            }



            return sentences;
        }
    }
}
