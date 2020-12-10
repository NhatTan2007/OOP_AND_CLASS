using System;
using System.Collections.Generic;
using System.Text;

namespace BAI_TAP_THEM
{
    class Matrix
    {
        private int[,] _randomMatrix = new int[0, 0];
        public int[,] RandomMatrix { get => _randomMatrix; set => _randomMatrix = value; }
        private static int _countMatrix = 0;
        public static int CountMatrix { get => _countMatrix; set => _countMatrix = value; }

        public Matrix()
        {

        }

        public Matrix(int row, int column, int minNum = 10, int maxNum = 100)
        {
            GenerateMatrix(row, column, minNum, maxNum);
            CountMatrix++;
        }

        public static void Menu()
        {
            Console.WriteLine("-----------Menu-----------");
            Console.WriteLine("\n1. Sinh ma trận trong khoảng [10, 100]");
            Console.WriteLine("2. Hiển thị ma trận trên");
            Console.WriteLine("3. Tính tổng giá trị trong ma trận");
            Console.WriteLine("4. Số lượng số nguyên tố có trong ma trận");
            Console.WriteLine("5. Số lượng số lẻ có trong ma trận");
            Console.WriteLine("6. Tổng giá trị trên đường biên");
            Console.WriteLine("7. Tính tích các giá trị trên 1 hàng");
            Console.WriteLine("8. Tính tích các giá trị trên 1 cột");
            Console.WriteLine("0. Thoát");
        }

        public void GenerateMatrix(int height, int width, int minNum = 10, int maxNum = 100)
        {
            Random randomNumber = new Random();
            int[,] randomArray = new int[height, width];
            for (int i = 0; i < randomArray.GetLength(0); i++)
            {
                for (int j = 0; j < randomArray.GetLength(1); j++)
                {
                    randomArray[i, j] = randomNumber.Next(minNum, maxNum + 1);
                }
            }
            _randomMatrix = randomArray;
        }

        public static void DisplayMatrix(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}, ");
                }
                Console.Write("\n");
            }
        }

        public static int SumAllElementsMatrix(int[,] array)
        {
            int sumTotal = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sumTotal += array[i, j];
                }
            }
            return sumTotal;
        }

        public static int TotalPrimesInArray(int[,] array)
        {
            int countPrimes = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (IsPrime(array[i, j])) countPrimes++;
                }
            }
            return countPrimes;
        }

        private static bool IsPrime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static int TotalOddInArray(int[,] array)
        {
            int countOdd = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 != 0) countOdd++;
                }
            }
            return countOdd;
        }
        public static int SumOfElementsInSidesOfArray(int[,] array)
        {
            int totalSumSide = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i == 0 || i == array.GetLength(0) - 1) || (i != 0 && i != array.GetLength(0) - 1) && (j == 0 || j == array.GetLength(1) - 1))
                    {
                        totalSumSide += array[i, j];
                    }
                }
            }
            return totalSumSide;
        }

        public static ulong MultiplyInRowOfArray(int[,] array, int row)
        {
            ulong multiplyRow = 1;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                multiplyRow *= (ulong)array[row, i];
            }
            return multiplyRow;
        }

        public static ulong MultiplyInColumnOfArray(int[,] array, int column)
        {
            ulong multiplyColumn = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                multiplyColumn *= (ulong)array[i, column];
            }
            return multiplyColumn;
        }


    }
}
