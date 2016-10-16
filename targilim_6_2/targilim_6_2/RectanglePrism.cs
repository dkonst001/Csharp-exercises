using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targilim_6_2
{
    class RectanglePrism
    {
        long _hight;
        long _width;
        long _length;

        public long Hight
        {
            get
            {
                return _hight;
            }

            set
            {
                _hight = value;
            }
        }

        public long Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }
        }

        public long Length
        {
            get
            {
                return _length;
            }

            set
            {
                _length = value;
            }
        }

        public RectanglePrism()
        {
            Hight = 0;
            Width = 0;
            Length = 0;
        }

        public long PrismVolume()
        {
            return Hight*Length*Width;
        }

        public long PrismArea()
        {
            return 2*Hight*Length+2*Hight*Width+2*Width*Length;
        }
    }
}
