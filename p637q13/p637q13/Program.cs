using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace p637q13
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder outLine = new StringBuilder();
            

            try
            {
                StreamReader wordsReader = new StreamReader("C:\\Users\\Dell\\Downloads\\words2.txt");
                StreamReader textReader = new StreamReader("C:\\Users\\Dell\\Downloads\\text.txt");
                StreamWriter outFile = new StreamWriter("C:\\Users\\Dell\\Downloads\\result.txt");

                string words = wordsReader.ReadToEnd();
                string textFile = textReader.ReadToEnd();

                string[] wordsArray = words.Split(' ', '\r', '\n');
                int[] wordsCount = new int[wordsArray.Length];

                for (int i = 0; i < wordsArray.Length; i++)
                {
                    wordsCount[i] = 0;
                    int n = 0;

                    if (wordsArray[i] != "")
                    {
                        while ((n = textFile.IndexOf(wordsArray[i], n, StringComparison.InvariantCulture)) != -1)
                        {
                            n += wordsArray[i].Length;
                            ++wordsCount[i];
                        }
                    }
                }

                Array.Sort(wordsCount, wordsArray);

                int j = wordsCount.Length - 1;
                while ((wordsCount[j] > 0) && (j > 0))
                {
                    outFile.WriteLine(wordsArray[j]);
                    j--;
                }

                string[] textArray = textFile.Split(' ', '\r', '\n', '=', '(', ')', '!', '[', ']', ';', '.');

                for (int i = 0; i < textArray.Length; i++)
                {
                    if (textArray[i].Trim() != "")
                    {
                        int loc = FindWord(textArray[i], wordsArray);

                        if (loc >= 0) Console.WriteLine("The word {0} is found at location {1}", textArray[i], loc);
                        else Console.WriteLine("The word {0} is not found", textArray[i]);
                    }

                }
                Console.ReadLine();

                wordsReader.Close();
                textReader.Close();
                outFile.Close();

            }
            catch
            {

            }
            finally
            {


            }


        }

        private static int FindWord(string word, string[] words)
        {

            return Array.IndexOf(words, word);

        }


    }
}
