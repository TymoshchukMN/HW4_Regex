using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HW4_Regex
{
    internal class UI
    {
        public static void PrintRes(string str, ConsoleColor color)
        {
            ConsoleColor def = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(str);
            Console.ForegroundColor = def;
        }

        public static void PrintRequest()
        {
            Console.Write("Введеите строку для проверки:\t");
        }
    }
}
