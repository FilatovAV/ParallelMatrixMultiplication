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
            mConsole.GetInteger("Enter the size of the matrix on 1 side:", ref a);
            if (a>0)
            {
                Math math = new Math(a);
                int[,] matrixResult = math.MatrixMult(math.matrix1, math.matrix2);

                math.PrintMatrix(math.matrix1, "\nMatrix №1");
                math.PrintMatrix(math.matrix2, "\nMatrix №2");
                math.PrintMatrix(matrixResult, "\nMatrix multiplication №1, №2");

                Console.WriteLine($"\nTime elapsed: {math.timeElapsed}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The size of the matrix must be greater than 0.");
            }


            Console.ReadKey();
        }
    }
}
