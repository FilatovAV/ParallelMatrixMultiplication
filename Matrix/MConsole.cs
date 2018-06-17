using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class MConsole
    {
        /// <summary>
        /// функция возвращает число (целочисленное) из консоли
        /// </summary>
        /// <param name="Question"></param>
        /// <param name="ResInt"></param>
        /// <returns></returns>
        public Boolean GetInteger(string Question, ref int ResInt)
        {
            string s = GetString(Question);
            if (int.TryParse(s, out ResInt))
            {
                return true;
            }
            else
            {
                ConsoleColor cfc = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Введено недопустимое значение - {s}!");
                Console.ForegroundColor = cfc;
                Console.ReadKey();
                return false;
            }
        }

        /// <summary>
        /// функция возвращает строку из консоли
        /// </summary>
        /// <param name="Question"></param>
        /// <returns></returns>
        public string GetString(string Question)
        {
            try
            {
                Console.Write(Question);
                return Console.ReadLine();
            }
            catch
            {
                return "";
            }
        }
    }
}
