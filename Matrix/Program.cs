﻿using System;

namespace Matrix // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static bool isRandom = false;
        public static bool secondMatrix = false;
        public static int tempHeight = 0;
        public static Random random = new Random();
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Run();
                }
                catch (Exception error)
                {
                    HandleError(error);
                }
            }
        }

        static void Run()
        {
            Console.Clear();
            Console.WriteLine("Type \"random\" for generating random matrix or enter for manual input");

            tempHeight = 0;
            secondMatrix = false;

            var watch = new System.Diagnostics.Stopwatch();
            long timeDefault = 0;
            long timeParallel = 0;

            int[,] input = GetInput(500, 1000);
            long[,] a = GenerateMatrix(input[0, 0], input[0, 1]);
            long[,] b = GenerateMatrix(input[1, 0], input[1, 1]);
            
            watch.Start();
            var result = MatrixMultiplication(a, b);
            watch.Stop();
            timeDefault = watch.ElapsedMilliseconds;

            watch.Restart();
            MatrixMultiplicationParallel(a, b);
            watch.Stop();
            timeParallel = watch.ElapsedMilliseconds;
            

            if (!isRandom)
                RenderMatrix(result,true);

            Console.WriteLine($"Default Method Execution Time: {timeDefault} ms");
            Console.WriteLine($"Parallel Method Execution Time: {timeParallel} ms");
            Console.WriteLine("\nPress enter to restart...");
            Console.ReadLine();
        }

        static long[,] MatrixMultiplication(long[,] matrixOne, long[,] matrixTwo)
        {
            long[,] resultMatrix = new long[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    for (int c = 0; c < matrixOne.GetLength(1); c++)
                        resultMatrix[i, j] += matrixOne[i, c] * matrixTwo[c, j];
                }
            }
            return resultMatrix;
        }

        static long[,] MatrixMultiplicationParallel(long[,] matrixOne, long[,] matrixTwo)
        {
            long[,] resultMatrix = new long[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
            Parallel.For(0, resultMatrix.GetLength(0), (i) =>
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    for (int c = 0; c < matrixOne.GetLength(1); c++)
                        resultMatrix[i, j] += matrixOne[i, c] * matrixTwo[c, j];
                }
            });
            return resultMatrix;
        }

        static int[,] GetInput(int min = 2,int max = 5)
        {
            isRandom = Console.ReadLine().ToLower() == "random";

            int heightOne = random.Next(min, max);
            int widthOne = random.Next(min, max);
            int heightTwo = widthOne;
            int widthTwo = random.Next(min, max);

            if (!isRandom)
            {
                Console.WriteLine("Please provide height and width of first matrix");
                
                Console.Write("Height:");
                heightOne = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Width:");
                widthOne = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("\nPlease provide height and width of second matrix");
                
                Console.Write("Height:");
                heightTwo = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Width:");
                widthTwo = Convert.ToInt32(Console.ReadLine());

                tempHeight = heightOne;
            }
            Console.WriteLine();
            tempHeight = heightOne;
            return new int[,] {{ heightOne, widthOne }, { heightTwo, widthTwo }};
        }

        static long[,] GenerateMatrix(int a,int b)
        {
            var random = new Random();
            long[,] matrix = new long[a, b];
            if (!isRandom)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = -99999999999999;
                        RenderMatrix(matrix);
                        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                RenderMatrix(matrix);
            }
            else
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                        matrix[i, j] = random.NextInt64(long.MinValue, long.MaxValue);
                }
            }
            secondMatrix = true;
            return matrix;
        }

        static void RenderMatrix(long[,] matrix,bool isResult = false)
        {
            if (!isResult)
            {
                int cursorLevel = isRandom ? 4 : 11;
                Console.SetCursorPosition(0, !secondMatrix ? cursorLevel : cursorLevel + 2 + tempHeight);
                Console.WriteLine((!secondMatrix ? "First" : "Second") + " matrix:");
            }
            string result = "";
            for (long i = 0; i < matrix.GetLength(0); i++)
            {
                for (long j = 0; j < matrix.GetLength(1); j++)
                    result += (matrix[i,j] != -99999999999999 ? matrix[i,j] : "x") + " ";
                result += "\n";
            }
            Console.WriteLine((isResult ? "Result:\n": "") + result);
        }
        
        static void HandleError(Exception error)
        {
            Console.WriteLine("\nSomething went wrong: {0}\nPress enter to restart...", error.Message);
            Console.ReadLine();
        }
    }
}