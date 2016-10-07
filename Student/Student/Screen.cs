using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Student
{
    public class Screen
    {
        decimal _size;
        Color _color;

        public decimal Size
        {
            get
            {
                return _size;
            }

            set
            {
                _size = value;
            }
        }

        private Color Color
        {
            get
            {
                return _color;
            }

            set
            {
                _color = value;
            }
        }

        public Screen(decimal size, Color color)
        {
            Size = size;
            Color = color;
        }
    }
}

