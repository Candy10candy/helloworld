using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    class Square
    {
        private int length;
        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public Square(int l)
        {
            length = l;
           

        }

        public int getArea()
        {
            return length * length;

        }

        public int getPerimeter()
        {
            return 4 * length;

        }


    }
}
