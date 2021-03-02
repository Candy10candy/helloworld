using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp
{
    class Rectangle
    {
        private int width;
        public int Width
        { 
            get { return width; }
            set { width = value; }
        }
        private int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public Rectangle(int w, int h)
        {
            this.width = w;
            this.height = h;
        
        }

        public int getArea() 
        {
            return width * height;
        
        }

        public int getPerimeter()
        {
            return 2 * (width + height);
        
        }


    }
}
