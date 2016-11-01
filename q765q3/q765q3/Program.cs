using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace q765q3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a program that counts how many times each word from 
            //a given text file words.txt appears in it.
            //The result words should be ordered by their number of occurrences 
            //in the text.
            //Example: "This is the TEXT. Text, text, text – THIS TEXT! Is this the text?"
            //Result: is  2, the  2, this  3, text  6.

            //Solution:
            //Read all rows
            //Remmove all punctuations
            //Change all to lower case
            //Use Dictionary< string, int> with word as a key and number of occurrences 
            //as a value.
            //After counting all the words, 
            //sort the dictionary by value using sorted = dictionary.OrderBy(p => p.Value);

            try
            {

                StreamReader reader = new StreamReader("C:\\Users\\Dell\\Downloads\\words.txt");

                //Read the entire file into a string
                string file = reader.ReadToEnd();

                //Convert to lower case
                string lowerFile = file.ToLower();

                //Convert to list of char's
                List<char> lisChar = file.ToList();

                //All those which are not letter or digit will be used to split into words
                List<char> lisToSplit = lisChar.FindAll(c => (!char.IsLetter(c) && !char.IsDigit(c)));

                char[] arrToSplit = lisToSplit.ToArray();
                string[] wordsInFile = lowerFile.Split(arrToSplit);

                //Cast from array of strings to list of strings
                List<string> listWords = wordsInFile.ToList();

                //Remove blank strings
                listWords.RemoveAll(wr => wr == "");

                //Dictionary of counters
                Dictionary<string, int> cnTs = new Dictionary<string, int>();

                foreach (string word in listWords)
                {
                    //If the key is not in the dictionary, cout all the wors and add to the dictionary
                    if (!cnTs.ContainsKey(word)) cnTs.Add(word, listWords.Count(wr => wr == word));
                }
                //sortedDict.ToDictionary<KeyValuePair<string, int>, string, int>(pair => pair.Key, pair => pair.Value);
                IEnumerable<KeyValuePair<string, int>> enumSortedWords = cnTs.OrderBy(pair => pair.Value);
                Dictionary<string, int> sortedWords = enumSortedWords.ToDictionary(pair => pair.Key, pair => pair.Value);

                PrintDictionary(sortedWords);
                Console.ReadLine();


            }
            catch
            {

            }
            finally
            {

            }

        }
        static void PrintDictionary(Dictionary<string, int> dic)
        {
            foreach (KeyValuePair<string, int> pair in dic)
            {
                Console.WriteLine("Word \"{0}\" appears {1} times in the file", pair.Key, pair.Value);
            }
        }
    }
}
