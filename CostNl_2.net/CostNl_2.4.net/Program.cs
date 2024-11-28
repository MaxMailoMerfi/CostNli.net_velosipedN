namespace CostNl_2._4.net
{
    internal class Program
    {
        static void Main()
        {
            Random random = new ();
            for (; ; )
            {
                int attempts = 0, namberOne = 1, namberTuo = 1, namberThre = 1, namberFour = 1;

                // Генерация случайного 4-значного пароля
                Console.WriteLine("Программа загадала 4-значный пароль. Попробуйте угадать его!");
                string Password = random.Next(1000, 10000).ToString(), input, check, checkTuo = "XXXX"; // Пароль, ввод пароля, сохранение проверки, помощо для проверки

                for (; ; )
                {
                    Console.Write("Введите ваш вариант: ");

                    //input = Console.ReadLine();
                    Console.WriteLine($"{namberOne}{namberTuo}{namberThre}{namberFour}");


                    attempts++;// + попытка

                    // Проверка пароля
                    input = "";
                    input += $"{namberOne}{namberTuo}{namberThre}{namberFour}";
                    check = "";
                    for (int i = 0; i < 4; i++)
                    {
                        if (input[i] == Password[i])
                        {
                            check += input[i]; // Якщо число и позиция правильная
                        }
                        else
                        {
                            check += "X"; // Вводими "X" как неверное

                            // переводим к следущему
                            switch (i)
                            {
                                case 0:
                                    if (namberOne < 9) namberOne++;
                                    else namberOne = 0;
                                    break;
                                case 1:
                                    if (namberTuo < 9) namberTuo++;
                                    else namberTuo = 0;
                                    break;
                                case 2:
                                    if (namberThre < 9) namberThre++;
                                    else namberThre = 0;
                                    break;
                                case 3:
                                    if (namberFour < 9) namberFour++;
                                    else namberFour = 0;
                                    break;
                            }
                        }
                    }

                    Console.WriteLine($"Результат: {check}");

                    // Если пароль верный
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
