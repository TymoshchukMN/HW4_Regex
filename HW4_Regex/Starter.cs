using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW4_Regex
{
    internal class Starter
    {
        public static void Run()
        {
            //////
            // Користувач вводить строку. Виконайте перевірку, використовуючи регулярні вирази:
            // Що строка введена латиницею і не містить окремих букв кирилиці або цифр;
            // Строка введена латиницею і містить окремі літери кирилиці, не містить цифри;
            // Строка введена латиницею і містить цифри, не містить кирилицю.
            ///////

            string userInput = string.Empty;
            const string Exit = "exit";

            // 1. о строка введена латиницею і не містить окремих букв кирилиці або цифр;
            const string Mask1 = @"^[a-zA-Z]+$";
            Regex regex = new Regex(Mask1);
            do
            {
                UI.PrintRequest();
                userInput = Console.ReadLine();

                if (regex.Match(userInput).Success)
                {
                    UI.PrintRes("Условия выполнены.\n", ConsoleColor.Green);
                }
                else
                {
                    UI.PrintRes("Условия НЕ выполнены.\n", ConsoleColor.Red);
                }
            }
            while (userInput != Exit);
        }
    }
}
