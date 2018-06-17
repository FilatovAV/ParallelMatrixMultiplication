using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Math
    {
        //Размер матрицы ixj
        readonly int mLen;

        public readonly int[,] matrix1;
        public readonly int[,] matrix2;
        public int[,] matrixResult;

        static Random rnd = new Random();

        /// <summary>
        /// Конструктор формирует 2 матрицы с указаным размером (квадрат). 
        /// Заполняя произвольными числами от 0 до 10.
        /// </summary>
        /// <param name="mSize"></param>
        public Math(int mSize)
        {
            mLen = mSize;
            matrix1 = new int[mSize, mSize];
            matrix2 = new int[mSize, mSize];
            matrixResult = new int[mSize, mSize];

            //создаем 2 матрицы
            for (int i = 0; i < mSize; i++)
            {
                for (int j = 0; j < mSize; j++)
                {
                    matrix1[i, j] = rnd.Next(0, 11);
                    matrix2[i, j] = rnd.Next(0, 11);
                }
            }
        }

        /// <summary>
        /// Произведение двух матриц
        /// </summary>
        /// <param name="matrix1"></param>
        /// <param name="matrix2"></param>
        public int[,] MatrixMult(int[,] matrix1, int[,] matrix2)
        {
            //строки результирующей матрицы
            for (int iLine = 0; iLine < mLen; iLine++)
            {
                Parallel.For(0, mLen, (i) =>
                                            {
                                                for (int iIncrement = 0; iIncrement < mLen; iIncrement++)
                                                {
                                                    matrixResult[iLine, i] +=
                                                    matrix1[iLine, iIncrement] * matrix2[iIncrement, i];
                                                }
                                            }
                );
            }
            return matrixResult;
        }

        /// <summary>
        /// Отобразить матрицу в консоли
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="name"></param>
        public void PrintMatrix(int[,] matrix, string name)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(name + Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.Gray;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
