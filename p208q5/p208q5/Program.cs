using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p208q5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitLoop = false;


            do
            {
                Console.Write("Enter a number between 1 to 4999 or 0 to EXIT: ");
                int numToRoman = Int32.Parse(Console.ReadLine());

                int[] index = new int[2];

                string romanNumber="";

                if (numToRoman == 0) break;
                else romanNumber = CheckRange(numToRoman);

                
                Console.WriteLine("The Roman translation of {0} is {1} . Press any key to continue", numToRoman, romanNumber);
            } while (!exitLoop);

         }

        static public string CheckRange(int num)
        {
            int[] ranges = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string romanNumber = "";

            for (int i = 0; i < ranges.Length; i++)
            {
                
                int reminder = num / ranges[i];
                num = num % ranges[i];
                while (reminder > 0)
                {
                    switch (i)
                    {
                        case (0):
                            romanNumber += "M";
                            break;
                        case (1):
                            romanNumber += "CM";
                            break;
                        case (2):
                            romanNumber += "D";
                            break;
                        case (3):
                            romanNumber += "CD";
                            break;
                        case (4):
                            romanNumber += "C";
                            break;
                        case (5):
                            romanNumber += "XC";
                            break;
                        case (6):
                            romanNumber += "L";
                            break;
                        case (7):
                            romanNumber += "XL";
                            break;
                        case (8):
                            romanNumber += "X";
                            break;
                        case (9):
                            romanNumber += "IX";
                            break;
                        case (10):
                            romanNumber += "V";
                            break;
                        case (11):
                            romanNumber += "IV";
                            break;
                        case (12):
                            romanNumber += "I";
                            break;
  
                        default:
                            //exitLoop = true;
                            break;
                    }
                    reminder--;
                }
            }
            return romanNumber;
        }
    }
}
