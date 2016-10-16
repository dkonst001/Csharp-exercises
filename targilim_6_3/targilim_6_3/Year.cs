using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim_6_3
{
    public class Year
    {
        int _year;
        public Year(int year)
        {

            if ((year >= 0) && (year < 17)) Year_ = 2000 + year;
            else if ((year >= 1900) & (year < 2017)) Year_ = year;
            else Year_ = 1900;
        }

        public bool IsLeapYear()
        {
            return (((Year_ % 4 == 0) && (Year_ % 100 != 0)) 
                ||
                ((Year_ % 100 == 0) && (Year_ % 400 == 0)));
        }

        public int Year_
        {
            get
            {
                return _year;
            }

            set
            {
                _year = value;
            }
        }
    }
}
