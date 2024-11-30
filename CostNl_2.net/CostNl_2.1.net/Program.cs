using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CostNl_2._1.net
{
    internal class Program
    {
        static void Main()
        {
            Random random = new();
            int bid, one, tuo, thre; // Основные
            double sum, Win = 0;
            int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; // Масив для визуала
            int Hack = 42, sumHack = -1; // читы (код, сколько бабок
            int delay = 400, scrolls = 10;// скорость анимации, количество прокруток
            string kazino = "$Казино$", textHack, text, input; //Название, тексти, ввод з клавы

            textHack = "\nКод поражен твоими познаниями, но какой ценой?"; // Читы

            for (; ; )
            {
                Console.WriteLine("Вас приветсвует йобаное казино");


                for (; ; ) // Проверка на верное количество
                {
                    Console.WriteLine("\nВведите ваш баланс денег от 5$ до 1000$");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out _))
                    {
                        sum = int.Parse(input);
                        if ((sum >= 5) && (sum <= 1000))
                        {
                            break;
                        }
                    }
                    Console.Clear();
                    Console.WriteLine(kazino);
                    Console.WriteLine("\nНекорректный ввод");
                }
                for (; ; )
                {
                    // Проверка баланса sum
                    if (sum < 5)
                    {
                        Console.WriteLine($"\nК сожалению (вашему) в вас на балансе = {sum}$ и ето меньше 5$");
                        Console.WriteLine($"Но вы всегда можете вернутся сюда с деньгами, и в другой раз вам повезет(нет)");
                        Console.WriteLine("\nЕсли в вас есть что чтобы предложыть, то нажмите на любую клавишу");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }


                    Console.Clear();
                    Console.WriteLine(kazino);
                    for (; ; ) // Проверка на верную ставку
                    {
                        Console.WriteLine($"\nТвой баланс составляет: {sum}$");
                        Console.WriteLine("\nСделайте ставку то 5$ до 100$, з шагом 5$");
                        Console.Write("Ставка :");
                        input = Console.ReadLine();
                        if (int.TryParse(input, out _))
                        {
                            bid = int.Parse(input);
                            if (((bid % 5 == 0) && (bid > 0) && (bid <= 100) && (bid <= sum)) || (bid == Hack))
                            {
                                sum -= bid;
                                break;
                            }
                        }
                        Console.Clear();
                        Console.WriteLine(kazino);
                        Console.WriteLine("\nНекорректный ввод");
                    }

                    text = $"\nТвоя ставка составляет: {input}$"; // Обичний


                    if (bid == Hack) //Хак
                    {
                        text = textHack;
                        bid = sumHack;
                        one = 7;
                        tuo = 7;
                        thre = 7;
                    }
                    else //Рандом главного
                    {
                        one = random.Next(1, 10);
                        tuo = random.Next(1, 10);
                        thre = random.Next(1, 10);
                    }

                    //Анимация прокрутки
                    for (int n = 0; n < scrolls - 2; n++)
                    {
                        Console.Clear();
                        Console.WriteLine(kazino);
                        Console.WriteLine($"\nТвой баланс составляет: {sum}$");
                        Console.WriteLine(text);

                        if (n == 0)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                for (int j = 0; j < 3; j++)
                                {
                                    num[i, j] = random.Next(1, 10);
                                }
                            }
                        }
                        else
                        {
                            for (int i = 2; i >= 0; i--)
                            {
                                for (int j = 0; j < 3; j++)
                                {
                                    if (i == 0) { num[0, j] = random.Next(1, 10); }
                                    else
                                        num[i, j] = num[i - 1, j];
                                }

                            }
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine();
                            if (i == 1) Console.Write("-|"); else Console.Write(" |");
                            for (int j = 0; j < 3; j++)
                            {
                                Console.Write($"{num[i, j]}|");
                            }
                            if (i == 1) Console.Write("-");
                        }

                        Thread.Sleep(delay);
                    }

                    //Вывод табло
                    for (int n = 0; n < 2; n++)
                    {
                        Console.Clear();
                        Console.WriteLine($"{kazino}\n\n");
                        Console.WriteLine(text);

                        for (int i = 2; i >= 0; i--)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                if (i == 0 && n != 0) { num[0, j] = random.Next(1, 10); }
                                else if (i > 0)
                                    num[i, j] = num[i - 1, j];
                                else
                                {
                                    num[0, 0] = one;
                                    num[0, 1] = tuo;
                                    num[0, 2] = thre;
                                }
                            }
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine();
                            if (i == 1) Console.Write("-|"); else Console.Write(" |");
                            for (int j = 0; j < 3; j++)
                            {
                                Console.Write($"{num[i, j]}|");
                            }
                            if (i == 1) Console.Write("-");
                        }

                        Thread.Sleep(delay);
                    }

                    //Вычет и вывод результата
                    if ((one == tuo) && (one == thre))
                    {
                        if (one == 7)
                        {
                            Win = bid * 150 * 1.5;
                            Console.WriteLine($"\n\nПоздравляем у вас джекпот \nВаш джекпот будет составлять = {Win}");
                        }
                        else
                        {
                            Win = bid * (one * 10) * 1.5;
                            Console.WriteLine($"\n\nПоздравляем у вас три {one} = {Win}");
                        }
                    }
                    else
                    {
                        if ((one == tuo) || (one == thre))
                        {
                            if (one == 7)
                            {
                                Win = bid * 15 * 1.25;
                                Console.WriteLine($"\n\nПоздравляем у вас Мини-Джекпот \nВаш выигрыш = {Win}$");
                            }
                            else
                            {
                                Win = bid * one * 1.25;
                                Console.WriteLine($"\n\nПоздравляем у вас две {one}  \nВаш выигрыш = {Win}$");
                            }
                        }
                        else if (tuo == thre)
                        {
                            if (tuo == 7)
                            {
                                Win = bid * 15 * 1.25;
                                Console.WriteLine($"\n\nПоздравляем у вас Мини-Джекпот \nВаш выигрыш = {Win}$");
                            }
                            else
                            {
                                Win = bid * tuo * 1.25;
                                Console.WriteLine($"\n\nПоздравляем у вас две {tuo} \nВаш выигрыш = {Win}$");
                            }
                        }
                        else
                        {
                            Win = 0;
                            Console.WriteLine("\n\nСочувствуем, но вам не повезло\nПопробуйте еще раз");
                        }
                    }
                    Console.WriteLine($"\nТвой баланс составляет: {sum += Win}$");
                    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine(kazino);
                }
            }
        }
    }
}
