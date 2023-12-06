// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


using System.Runtime.InteropServices;

namespace Task_01
{
    public static class Program
    {
        public static void Main(string [] args)
        {
            int [,] twoDimArray = CreateTwoDimArray(4, 4, 1, 9);
           
            Print(twoDimArray);
            int minSum = 1;
            int sum = FindMinSum(twoDimArray, 0);
            for (int i = 1; i < twoDimArray.GetLength(0); i++)
            {
                if (sum > FindMinSum(twoDimArray, i))
                {
                    sum = FindMinSum(twoDimArray, i);
                    minSum = i+1;
                }
            }
            
            System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSum}");            
            
            
        }

        public static int [,] CreateTwoDimArray(int rows, int cols, int min, int max)
        {
            int [,] twoDimArray = new int[rows, cols];
            Random rand = new();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    twoDimArray[i,j] = rand.Next(min, max+1);
                }
            }

            return twoDimArray;
        }

        public static void Print(int [,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    System.Console.Write(array[i,j] + "\t");
                }
                System.Console.WriteLine();
            }
        }

        public static int FindMinSum(int [,] array, int i)
        {
            
            int cols = array.GetLength(1);
           
            int sum = array[i,0];
            for (int j = 1; j < cols; j++)
            {
                sum += array[i,j];
            }
            return sum;
            
            
        }
    }
}




