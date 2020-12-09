using System;
using System.Text;

namespace XAY_DUNG_LOP_FAN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Fan firstFan = new Fan();
            Fan secondFan = new Fan();

            firstFan.Speed = Fan.FAST;
            firstFan.Radius = 10;
            firstFan.Color = "yellow";
            firstFan.On = true;

            secondFan.Speed = Fan.MEDIUM;

            Console.WriteLine(firstFan.DisplayFan());
            Console.WriteLine(secondFan.DisplayFan());
        }
    }
}
