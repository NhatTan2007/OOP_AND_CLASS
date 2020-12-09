using System;

namespace XAY_DUNG_LOP_STOPWATCH
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int[] sampleArray = new int[100000];


            StopWatch newStopWatch = new StopWatch();

            for (int i = 0; i < sampleArray.Length; i++)
            {
                sampleArray[i] = randomNumber.Next(1, 5001);
            }
            newStopWatch.Start();
            sortMinToMaxInArray(ref sampleArray);
            newStopWatch.Stop();
            Console.WriteLine($"{newStopWatch.GetElapsedTime()}");




        }

        static int[] sortMinToMaxInArray(ref int[] arrayInput)
        {
            for (int i = 0; i < arrayInput.Length; i++)
            {
                int minIndex = i;
                for (int j = i; j < arrayInput.Length; j++)
                {
                    if (arrayInput[minIndex] > arrayInput[j]) minIndex = j;
                }
                int temp = arrayInput[i];
                arrayInput[i] = arrayInput[minIndex];
                arrayInput[minIndex] = temp;
            }
            return arrayInput;
        }
    }
}
