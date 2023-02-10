/*
Author: Nicholas Makarov
Date: 2/8/2023
Comments: This C# Application code demonstrates the use of arrays utilizing the fibonacci sequence 
*/

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[25];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 2; i < 25; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Fibonacci number ({0}) = {1}", i, fibonacci[i]);
            }
        }
            }
        }
    
