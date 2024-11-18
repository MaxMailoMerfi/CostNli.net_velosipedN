namespace CostNl_2._4.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Генерация случайного 4-значного пароля
            Random random = new Random();
            string Password = random.Next(1000, 10000).ToString();
            int attempts = 0;


            Console.WriteLine("Программа загадала 4-значный пароль. Попробуйте угадать его!");

            for (; ; )
            {
                Console.Write("Введите ваш вариант: ");
                string input = Console.ReadLine();
                attempts++;// + попытка

                // Проверка введеного числа
                if (input.Length != 4 || !int.TryParse(input, out _))
                {
                    Console.WriteLine("Некорректный ввод. Введите 4-значное число.");
                    continue;
                }

                // Проверка з паролем
                string check = "";
                for (int i = 0; i < 4; i++)
                {
                    if (input[i] == Password[i])
                    {
                        check += input[i]; // Якщо число и позиция правильная
                    }
                    else
                    {
                        check += "X"; // Вводими "X" как не верное
                    }
                }

                Console.WriteLine($"Результат: {check}");

                // Якщо пароль угадано
                if (check == Password)
                {
                    Console.WriteLine($"Поздравляем! Вы угадали пароль: {Password}");
                    Console.WriteLine($"Количество попыток: {attempts}");
                    break;
                }
            }



        }
    }
}
