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
            #region TASK 1

            // 1. о строка введена латиницею і не містить окремих букв кирилиці або цифр;
            const string Mask1 = @"^[a-zA-Z]+$";
            Regex regex = new Regex(Mask1);

            ChekIfMatch(regex);

            #endregion TASK 1

            #region TASK2

            // Строка введена латиницею і містить окремі літери кирилиці, не містить цифри
            const string Mask2 = @"^[abcqwertyhu]+$";

            regex = new Regex(Mask2);

            ChekIfMatch(regex);


            #endregion TASK2

            Console.ReadKey();
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
