using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim_6_4
{
    class Program
    {
        static void Main(string[] args)
        {

            NumberToGuess num = new NumberToGuess();
            num.Create4RandomDigits();
            bool validNumber = false;
            string userNumber;
            do
            {
                Console.Write("Enter 4 different digits:");
                userNumber = Console.ReadLine();
                validNumber = num.CheckNumberValidity(userNumber);
            }
            while (validNumber == false);

            Console.WriteLine("Random Number: {0}, User Number {1}, Match result: {2}",
                num.RandomNumber(), userNumber, num.CheckNumber(userNumber));

            Console.ReadLine();
        }
    }
}
