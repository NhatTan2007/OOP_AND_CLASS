using System;

namespace BAI_TAP_THEM
{
    class Program
    {
        static void Main(string[] args)
        {
            int yourChoice;
            bool checkInput = false;
            Matrix[] listMatrix = new Matrix[0];
            while (true)
            {
                Matrix.Menu();
                do
                {
                    Console.Write("Nhập lựa chọn của bạn: ");
                    checkInput = int.TryParse(Console.ReadLine(), out yourChoice);
                } while (!checkInput || yourChoice < 0 || yourChoice > 8) ;
                switch (yourChoice)
                {
                    case 1:
                        int row = InputNumber("cao");
                        int column = InputNumber("rộng");
                        int numberMatrixWantToCreate;
                        do
                        {
                            Console.Write($"Nhập số lượng ma trận muốn tạo với chiều cao {row}, chiều rộng {column}: ");
                            checkInput = int.TryParse(Console.ReadLine(), out numberMatrixWantToCreate);
                        } while (!checkInput || numberMatrixWantToCreate <= 0);
                        Array.Resize(ref listMatrix, Matrix.CountMatrix + numberMatrixWantToCreate);
                        for (int i = 0; i < numberMatrixWantToCreate; i++)
                        {
                            listMatrix[Matrix.CountMatrix] = new Matrix(row, column);
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        if (Matrix.CountMatrix != 0)
                        {
                            uint indexMatrix = inputIndexMatrix();
                            Matrix.DisplayMatrix(listMatrix[indexMatrix].RandomMatrix);
                        } else
                        {
                            Console.WriteLine("\nBạn phải khởi tạo ma trận trước khi chọn chức năng này");
                        }
                        break;
                    case 3:
                        if (Matrix.CountMatrix != 0)
                        {
                            uint indexMatrix = inputIndexMatrix();
                            Console.WriteLine($"Tổng các phần tử của ma trận đã tạo là: {Matrix.SumAllElementsMatrix(listMatrix[indexMatrix].RandomMatrix)}");
                        }
                        else
                        {
                            Console.WriteLine("\nBạn phải khởi tạo ma trận trước khi chọn chức năng này");
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        if (Matrix.CountMatrix != 0)
                        {
                            uint indexMatrix = inputIndexMatrix();
                            Console.WriteLine($"Số lượng các số nguyên tố trong ma trận đã tạo là: {Matrix.TotalPrimesInArray(listMatrix[indexMatrix].RandomMatrix)}");
                        }
                        else
                        {
                            Console.WriteLine("\nBạn phải khởi tạo ma trận trước khi chọn chức năng này");
                        }
                        Console.WriteLine();
                        break;
                    case 5:
                        if (Matrix.CountMatrix != 0)
                        {
                            uint indexMatrix = inputIndexMatrix();
                            Console.WriteLine($"Số lượng số lẻ có trong ma trận đã tạo là: {Matrix.TotalOddInArray(listMatrix[indexMatrix].RandomMatrix)}");
                        }
                        else
                        {
                            Console.WriteLine("\nBạn phải khởi tạo ma trận trước khi chọn chức năng này");
                        }
                        Console.WriteLine();
                        break;
                    case 6:
                        if (Matrix.CountMatrix != 0)
                        {
                            uint indexMatrix = inputIndexMatrix();
                            Console.WriteLine($"Tổng các cạnh biên là: {Matrix.SumOfElementsInSidesOfArray(listMatrix[indexMatrix].RandomMatrix)}");
                        }
                        else
                        {
                            Console.WriteLine("\nBạn phải khởi tạo ma trận trước khi chọn chức năng này");
                        }
                        Console.WriteLine();
                        break;
                    case 7:
                        if (Matrix.CountMatrix != 0)
                        {
                            uint indexMatrix = inputIndexMatrix();
                            int rowInput;
                            do
                            {
                                Console.Write("Chọn hàng bạn muốn tính tích trong ma trận: ");
                                checkInput = int.TryParse(Console.ReadLine(), out rowInput);
                            } while (!checkInput || rowInput < 0 || rowInput >= listMatrix[indexMatrix].RandomMatrix.GetLength(0));
                            Console.WriteLine($"Tích của hàng {rowInput} là: {Matrix.MultiplyInRowOfArray(listMatrix[indexMatrix].RandomMatrix, rowInput)}");
                        }
                        else
                        {
                            Console.WriteLine("\nBạn phải khởi tạo ma trận trước khi chọn chức năng này");
                        }
                        Console.WriteLine();
                        break;
                    case 8:
                        if (Matrix.CountMatrix != 0)
                        {
                            uint indexMatrix = inputIndexMatrix();
                            int columnInput;
                            do
                            {
                                Console.Write("Chọn cột bạn muốn tính tích trong ma trận: ");
                                checkInput = int.TryParse(Console.ReadLine(), out columnInput);
                            } while (!checkInput || columnInput < 0 || columnInput >= listMatrix[indexMatrix].RandomMatrix.GetLength(1));
                            Console.WriteLine($"Tích của cột {columnInput} là: {Matrix.MultiplyInColumnOfArray(listMatrix[indexMatrix].RandomMatrix, columnInput)}");
                        }
                        else
                        {
                            Console.WriteLine("\nBạn phải khởi tạo ma trận trước khi chọn chức năng này");
                        }
                        Console.WriteLine();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        static int InputNumber(string size)
        {
            bool checkInput = false;
            int number;
            do
            {
                Console.Write($"Nhập chiều {size} của ma trận muốn tạo: ");
                checkInput = int.TryParse(Console.ReadLine(), out number);
            } while (!checkInput);
            return number;
        }

        static uint inputIndexMatrix()
        {
            uint indexMatrix;
            bool checkInput = false;
            Console.WriteLine($"Hiện có tổng cộng {Matrix.CountMatrix} đã được tạo.");
            do
            {
                Console.Write("Chọn ma trận (min là 1): ");
                checkInput = uint.TryParse(Console.ReadLine(), out indexMatrix);
            } while (!checkInput || indexMatrix <= 0 || indexMatrix > Matrix.CountMatrix);
            return indexMatrix - 1;
        }
    }


}
