using System;
using System.Text;

namespace XAY_DUNG_LOP_QUADRATICEQUATION
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            double inputA;
            double inputB;
            double inputC;
            bool checkInput = false;

            Console.WriteLine("[Bài tập] Xây dựng lớp QuadraticEquation (Phương trình bậc hai)\n");
            do
            {
                Console.Write("Nhập vào a: ");
                checkInput = double.TryParse(Console.ReadLine(), out inputA);
            } while (!checkInput);

            do
            {
                Console.Write("Nhập vào b: ");
                checkInput = double.TryParse(Console.ReadLine(), out inputB);
            } while (!checkInput);

            do
            {
                Console.Write("Nhập vào c: ");
                checkInput = double.TryParse(Console.ReadLine(), out inputC);
            } while (!checkInput);

            QuadraticEquation newQuad = new QuadraticEquation(inputA, inputB, inputC);

            if (newQuad.GetDiscriminant() > 0)
            {
                Console.Write($"Nghiệm thứ 1 của phương trình bậc 2: {newQuad.GetRoot1()}");
                Console.Write($"Nghiệm thứ 2 của phương trình bậc 2: {newQuad.GetRoot2()}");
            } else if(newQuad.GetDiscriminant() == 0)
            {
                Console.Write($"Phương trình bậc 2 có nghiệm: {newQuad.GetRoot1()}");
            } else
            {
                Console.Write($"Phương trình vô nghiệm");
            }
        }
    }
}
