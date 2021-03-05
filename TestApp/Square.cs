using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    class Square : Rectangle
    {
       public Square(int length) : base (length, length)
       {
       }

        public override int getPerimeter()
        { return Width * 4;  }

        public override int getArea()
        { return Width * Width; }

        public override string ToString()
        {
            return "I am a square";
        }

    }
}
