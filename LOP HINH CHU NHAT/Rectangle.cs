using System;
using System.Collections.Generic;
using System.Text;

namespace LOP_HINH_CHU_NHAT
{
    class Rectangle
    {
        private int _width;
        private int _height;

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        //public int Height{get => _height; set => _height = value;}
        public int Height { get => _height; set => _height = value; }
        public Rectangle()
        {

        }
        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public int getArea()
        {
            return Width * Height;
        }

        public int getPerimeter()
        {
            return (Width + Height) * 2;
        }

        public void Dispay()
        {
            Console.WriteLine($"Your Rectangle: width = {Width}, height = {Height}");
        }

    }
}
