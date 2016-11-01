using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p933q1
{
    
    public static class StringBuilderExtentions
    {
        public static StringBuilder SubString(this StringBuilder sb, int start, int charNum)
        {
            StringBuilder substr = new StringBuilder();

            for (int i = start; i < start + charNum; i++) substr.Append(sb[i]);

            return substr;
        }
    }
}
