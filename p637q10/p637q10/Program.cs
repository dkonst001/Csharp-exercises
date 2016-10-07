using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace p637q10
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder outLine = new StringBuilder();

            try
            {
                StreamReader reader = new StreamReader("C:\\Users\\Dell\\Downloads\\clearXMLtags.txt");
                StreamWriter outFile = new StreamWriter("C:\\Users\\Dell\\Downloads\\outWithouttags.txt");

                int numOfLine = 0;
                int numWordsInLine = 0;
                //int totalWords = 0;
                bool within = false;
                string line = reader.ReadLine();
                do
                {
                    int i = 0;  
                    numOfLine++;
                    within = false;
                    while (i < line.Length)
                    {
                        //Console.WriteLine("index: {0} Line length {1}", i, line.Length);
                        outLine.Clear();
                        if (line[i] == '<')
                        {
                            within = true;
                            i++;
                        }
                        while ((within == true) && (i<line.Length))
                        {
                            if (line[i] == '>')
                            {
                                within = false;
                            }
                            i++;
                        }
                        while ((within == false) && (i < line.Length))
                        {
                            if (line[i] == '<')
                            {
                                within = true;
                                if (outLine.ToString().Trim().Length>0)
                                {
                                    outFile.WriteLine(outLine);
                                    numWordsInLine++;
                                }
                            }
                            else
                            {
                                outLine.Append(line[i]);
                                
                            }
                            i++;
                        }
                    }
                line = reader.ReadLine();
                } while (line != null);
                //Console.WriteLine("Total number of words is {0}:", totalWords);
                Console.ReadLine();
                reader.Close();
                outFile.Close();

            }
            catch
            {

            }
            finally
            {


            }


        }
    }
}

