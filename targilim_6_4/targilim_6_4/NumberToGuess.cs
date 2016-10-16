using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim_6_4
{
    class NumberToGuess
    {
        int[] _number = new int[4];

        public int[] Number
        {
            get
            {
                return _number;
            }

            set
            {
                _number = value;
            }
        }

        public void Create4RandomDigits()
        {
            List<int> digits = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < 10; i++) digits.Add(i);

            for (int i = 0; i < 4; i++)
            {
                int digitLocation = rnd.Next(0, digits.Count);
                Number[i] = digits[digitLocation];
                digits.Remove(Number[i]);
            }
        }

        public bool CheckNumberValidity(string s)
        {
            if (s.Length != 4) return false;

            List<int> digits = new List<int>();

            for (int i = 0; i < 10; i++) digits.Add(i);

            for (int i = 0; i < 4; i++)
            {
                int digit = Int32.Parse(s[i].ToString());
                // check whetehr the digit is in the list <0,1,...,9>
                int index = digits.IndexOf(digit);
                // if the digit does not exist its becuse it appears more then once
                if (index == -1) return false;
                // if the digit exist
                else digits.Remove(digits[index]);
            }

            return true;

        }

        public string CheckNumber(string s)
        {
            
            int cntMatch = 0;
            int cntHit = 0;
            for (int i = 0; i < 4; i++)
            {
                
                int index = s.IndexOf(Char.Parse(Number[i].ToString()));
                
                if (index == i) cntMatch+=1;
               
                else if ((index != i) && (index !=-1)) cntHit+=1;
            }

            if (cntMatch == 4) return "Full Match";
            if (cntHit == 4) return "Full Hit";
            if ((cntHit==0)&&(cntMatch==0)) return "Miss";

            return String.Format("Matches {0}, Hits {1}", cntMatch, cntHit);
            


                       
        }

        public int RandomNumber()
        {
            int randomNumber=0;
            for (int i = 0; i < 4; i++)
            {
                randomNumber += Number[i] * (int)(Math.Pow(10, i));
            }

            return randomNumber;
        }


    }
}
