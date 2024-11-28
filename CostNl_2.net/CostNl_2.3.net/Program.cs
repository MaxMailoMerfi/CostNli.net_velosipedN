namespace CostNl_2._3.net
{
    internal class Program
    {
        static void Main()
        {
            Random random = new ();

            for (; ; )
            {
                // Генерация случайного 4-значного пароля
                string Password = random.Next(1000, 10000).ToString();
                int attempts = 0;
                Console.WriteLine("Программа загадала 4-значный пароль. Попробуйте угадать его!");

                for (; ; )
                {
                    Console.Write("\nВведите ваш вариант: ");
                    string input = Console.ReadLine();
                    attempts++;// + попытка)

                    // Проверка введеного числа
                    if (input.Length != 4 || !int.TryParse(input, out _))
                    {
                        Console.WriteLine("\nНекорректный ввод. Введите 4-значное число.");
                        continue;
                    }

                    // Проверка з паролем
                    string check = "";
                    for (int i = 0; i < 4; i++)
                    {
                        if (input[i] == Password[i])
                        {
                            check += input[i]; // Если число и позиция правильная
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

                        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                }
            }
        }
    }
}
