using System;
using System.Text;

namespace LOP_HINH_CHU_NHAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Rectangle firstSampleRectangle = new Rectangle();
            Rectangle secondSampleRectangle = new Rectangle(20, 10);

            firstSampleRectangle.Height = 20;
            firstSampleRectangle.Width = 50;

            secondSampleRectangle.Dispay();
            Console.WriteLine($"Second Rectangle's Area is: {secondSampleRectangle.getArea()}");
            Console.WriteLine($"Second Rectangle's Perimeter is: {secondSampleRectangle.getPerimeter()}\n");

            firstSampleRectangle.Dispay();
            Console.WriteLine($"First Rectangle's Area is: {firstSampleRectangle.getArea()}");
            Console.WriteLine($"First Rectangle's Perimeter is: {firstSampleRectangle.getPerimeter()}");
            firstSampleRectangle.getArea();
            firstSampleRectangle.getPerimeter();


        }
    }
}
