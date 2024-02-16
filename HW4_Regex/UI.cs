using System.Text;

namespace HW4_Task1
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
            Console.Write("Введеите строку для проверки." +
                "Для выхода напишите exit:\nСтрока#:");
        }

        public static void PrintRequestTaskNumber()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Выберите номер задачи.\n\n" +
                "1. строка введена латиницею і не містить окремих букв кирилиці або цифр\n" +
                "2. Строка введена латиницею і містить окремі літери кирилиці, не містить цифри;\n" +
                "3. Строка введена латиницею і містить цифри, не містить кирилицю.\n\n" +
                "Для выбора нажмите цифру 1, 2 или 3 в соответствии с номером задания.\n\n" +
                "Для выхода нажмите Esc");
        }

        public static void PrintErrorChoosingOperation()
        {
            Console.WriteLine("Не выерно выбран номе операции. \n" +
                "Выберите номер, нажав кнопку с цифрами 1, 2 или 3 в " +
                "соответствии с номером задания. Для выхода нажмите Esc");
        }
    }
}
