using System.Text.RegularExpressions;
using HW4_Task1;

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

            UI.PrintRequestTaskNumber();

            ConsoleKey inputedKey = Console.ReadKey(true).Key;
            switch (inputedKey)
            {
                case ConsoleKey.NumPad1:
                    ExecFirstTask();
                    break;
                case ConsoleKey.D1:
                    ExecFirstTask();
                    break;
                case ConsoleKey.NumPad2:
                    ExecSecondTask();
                    break;
                case ConsoleKey.D2:
                    ExecSecondTask();
                    break;
                case ConsoleKey.NumPad3:
                    ExecThirdTask();
                    break;
                case ConsoleKey.D3:
                    ExecThirdTask();
                    break;
                case ConsoleKey.Escape:
                    break;
                default:
                    UI.PrintErrorChoosingOperation();
                    break;
            }

            static void ExecFirstTask()
            {
                const string Mask1 = @"^[a-zA-Z]+$";
                ChekIfMatch(new Regex(Mask1));
            }

            static void ExecSecondTask()
            {
                // Строка введена латиницею і містить окремі літери кирилиці, не містить цифри
                const string Mask2 = @"^[abcqwertyhu]+$";
                ChekIfMatch(new Regex(Mask2));
            }

            static void ExecThirdTask()
            {
                // Строка введена латиницею і містить цифри, не містить кирилицю.
                const string Mask3 = @"^[a-zA-Z0-9]+$";
                ChekIfMatch(new Regex(Mask3));
            }
        }

        private static string ChekIfMatch(Regex regex)
        {
            const string Exit = "exit";
            string userInput;
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
            return userInput;
        }
    }
}
