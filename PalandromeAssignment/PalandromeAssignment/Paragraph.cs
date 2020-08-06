using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalandromeAssignment
{
    class Paragraph
    {
        List<Sentence> sentenceList = new List<Sentence>();
        List<Word> individualWordsList = new List<Word>();
        int palSentences;
        int palWords;


        //What delimiterChars
        char[] delimiterChars = { '.', '!', '?' };

        public void developTheParagraph(string paragraphText)
        {
            //first lets develop the words
            developWords(paragraphText);

            //next lets develop the sentences
            developSentences(paragraphText);
        }
        public void developWords(string paragraphText)
        {
            var sb = new StringBuilder();
            string[] individualWords;

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
                Word temp = new Word();
                temp.spelling = individualWords[i];
                temp.isPalindrome = checkIfPalendrome(individualWords[i]);
                if (temp.isPalindrome)
                {
                    palWords++;
                }
                if (individualWordsList.Contains(temp))
                {
                    temp.occuranceNumber++;
                }
                else
                {
                    temp.occuranceNumber = 1;
                }
                sb = new StringBuilder();
            }

            Console.WriteLine("YOU HAVE " + palWords + " Palindromes");
        }

        public void developSentences(string pText)
        {
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
                Sentence temp = new Sentence();
                temp.palendrome = checkIfPalendrome(words[i]);
                sentenceList.Add(temp);
                sb = new StringBuilder();
            }

            foreach (Sentence sentence in sentenceList)
            {
                if (sentence.palendrome)
                {
                    palSentences++;
                }
            }
            Console.WriteLine("YOU HAVE " + palSentences + " Palendrom sentences");
        }

        bool checkIfPalendrome(string txt)
        {
            Console.WriteLine("CHECKING: " + txt);
            if (txt != " " || txt != "")
            {
                char[] checker = txt.ToCharArray();
                Array.Reverse(checker);
                string reversed = new string(checker);

                bool pal = txt.Equals(reversed, StringComparison.OrdinalIgnoreCase);

                if (pal)
                {
                    Console.WriteLine(txt + " IS A palandrome");
                    return true;
                }
                else
                {
                    Console.WriteLine(txt + " IS NOT palandrome");
                    return false;
                }
            }
            else
                return false;
        }
    }
}

