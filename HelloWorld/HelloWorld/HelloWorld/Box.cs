using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Box
    {
        private int length;
        private int height;
        private int width;
        private int volume;

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.width = width;
        }

        public int FrontSurface
        {
            get
            {
                return length * height;
            }
        }

        public void SetLength(int length)
        {
            this.length = length;
        }

        public void SetHeight(int height)
        {
            this.height = height;
        }

        public void SetWidth(int width)
        {
            this.width = width;
        }

        public int GetLength()
        {
            return this.length;
        }

        public int GetHeight()
        {
            return this.height;
        }

        public int GetWidth()
        {
            return this.width;
        }


        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}", 
                length, height, width, volume = length * height * width);
        }
    }
}
