using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            MConsole mConsole = new MConsole();

            int a = 0;
            mConsole.GetInteger("Введите размер матрицы по 1 стороне:", ref a);
            if (a>0)
            {
                Math math = new Math(a);
                int[,] matrixResult = math.MatrixMult(math.matrix1, math.matrix2);

                math.PrintMatrix(math.matrix1, "\nМатрица №1");
                math.PrintMatrix(math.matrix2, "\nМатрица №2");
                math.PrintMatrix(matrixResult, "\nПроизведение матриц №1 и №2");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Размер матрицы должен быть больше 0.");
            }

            Console.ReadKey();
        }
    }
}
