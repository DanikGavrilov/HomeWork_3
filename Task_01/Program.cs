// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

using System.IO.Pipes;
using System.Runtime.CompilerServices;

namespace Task_01
{
    public static class Program
    {
        public static void Main(string [] args)
        {          
            
            int rows = 5;
            int cols = 5;       

            int [,] twoDimArray = new int[5, 5];
            Random rand = new();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    twoDimArray[i,j] = rand.Next(1, 100);
                }
            }

            rows = twoDimArray.GetLength(0);
            cols = twoDimArray.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    System.Console.Write(twoDimArray[i,j] + "\t");
                }
                System.Console.WriteLine();
            }

            int [] searchPos = [0, 3];
            
            int a = searchPos[0];
            int b = searchPos[1];

            
        
            if(a > rows || b > cols)
            {
                Console.WriteLine("Такого числа нет");
            }
            else
            {
                object? searchValue = twoDimArray.GetValue(a,b);
                Console.WriteLine(searchValue);
            }
            
            

        }

    }
}