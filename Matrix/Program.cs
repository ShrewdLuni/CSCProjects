using System;

namespace Matrix // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static bool isRandom = false;
        public static bool secondMatrix = false;
        public static int tempHeight = 0;
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    SetUpApp();
                    isRandom = Console.ReadLine().ToLower() == "random";
                    int[,] input = GetInput(isRandom,2,5);
                    RenderRestult(MatrixMultiplication(ConvertMatrix(GenerateMatrix(input[0, 0], input[0, 1], isRandom)), ConvertMatrix(GenerateMatrix(input[1, 0], input[1, 1], isRandom))));
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong");
                }
            }
        }

        static void SetUpApp()
        {
            Console.Clear();
            tempHeight = 0;
            secondMatrix = false;
            Console.WriteLine("Type \"random\" for generating random matrix or enter for manual input");
        }

        static int[,] GetInput(bool isRandom = false,int min = 2,int max = 5)
        {
            var random = new Random();
            int heightOne = random.Next(min, max);
            int widthOne = random.Next(min, max);
            int heightTwo = random.Next(min, max);
            int widthTwo = random.Next(min, max);
            if (!isRandom)
            {
                Console.WriteLine("Please provide height and width of first matrix");
                Console.Write("Height:");
                heightOne = Convert.ToInt32(Console.ReadLine());
                tempHeight = heightOne;
                Console.Write("Width:");
                widthOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Please provide height and width of second matrix");
                Console.Write("Height:");
                heightTwo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Width:");
                widthTwo = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            tempHeight = heightOne;
            return new int[,] {{ heightOne, widthOne }, { heightTwo, widthTwo }};
        }

        static void RenderRestult(int[][] matrix)
        {
            Console.WriteLine("Result:");
            Console.WriteLine(RenderMatrix(matrix));
            Console.WriteLine("Press enter to continue:");
        }

        static int[][] ConvertMatrix(string[][] matrix)
        {
            int[][] convertedMatrix = new int[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                convertedMatrix[i] = new int[matrix[0].Length];
                for (int j = 0; j < matrix[0].Length; j++)
                    convertedMatrix[i][j] = Convert.ToInt32(matrix[i][j]);
            }
            return convertedMatrix;
        }

        static string[][] GenerateMatrix(int a,int b,bool isRandom)
        {
            var random = new Random();
            string[][] matrix = new string[a][];
            for (int i = 0; i < a; i++)
                matrix[i] = new string[b];
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                    matrix[i][j] = random.Next(10).ToString();
            }
            Console.WriteLine((!secondMatrix ? "First" : "Second") +" matrix:");
            if (!isRandom)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[0].Length; j++)
                        matrix[i][j] = "0";
                }
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[0].Length; j++)
                    {
                        matrix[i][j] = "X";
                        RenderMatrix(ConvertMatrix(matrix));
                        matrix[i][j] = Convert.ToInt32(Console.ReadLine()).ToString();
                    }
                }
            }
            Console.WriteLine(WriteMatrix(matrix));
            secondMatrix = true;
            return matrix;
        }

        static string WriteMatrix(string[][] matrix)
        {
            int cursorLevel = isRandom ? 4 : 11;
            Console.SetCursorPosition(0, !secondMatrix ? cursorLevel : cursorLevel + 2 + tempHeight);
            return RenderMatrix(ConvertMatrix(matrix));
        }

        static string RenderMatrix(int[][] matrix)
        {
            string result = "";
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                    result += matrix[i][j] + " ";
                result += "\n";
            }
            return result;
        }

        static int[][] MatrixMultiplication(int[][] matrixOne, int[][] matrixTwo)
        {
            int[][] resultMatrix = new int[matrixOne.Length][];
            for (int i = 0; i < matrixOne.Length; i++)
                resultMatrix[i] = new int[matrixTwo[0].Length];

            for (int i = 0; i < resultMatrix.Length; i++)
            {
                for (int j = 0; j < resultMatrix[0].Length; j++)
                {
                    for (int c = 0; c < matrixOne[0].Length; c++)
                        resultMatrix[i][j] += matrixOne[i][c] * matrixTwo[c][j];
                }
            }
            return resultMatrix;
        }
    }
}