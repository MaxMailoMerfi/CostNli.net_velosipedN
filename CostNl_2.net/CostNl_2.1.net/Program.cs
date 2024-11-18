namespace CostNl_2._1.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int bid, one, tuo, thre; // Основные
            int hack = 42, bid_hack = -1; // читы (код, сколько бабок
            int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; // Масив для визуала
            int delay = 400, scrolls = 10;// скорость анимации, количество прокруток
            string kazino = "$Казино$"; //Название Которое будет сверху йобаного казино

            Console.WriteLine("Вас приветсвует йобаное казино");

            for (; ; )
            {
                for (; ; ) // Проверка на верную ставку
                {
                    Console.WriteLine("\nСделайте ставку то 5$ до 100$, з шагом 5$");
                    bid = int.Parse(Console.ReadLine());
                    if (((bid % 5 == 0) && (bid > 0) && (bid <= 100)) || (bid == hack))
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(kazino);

                        Console.WriteLine("\nНекорректный ввод");
                    }
                }
                if (bid == hack) //Хак
                {
                    bid = bid_hack;
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
                Console.Clear();
                for (int n = 0; n < scrolls-2; n++)
                {
                    Console.WriteLine(kazino);
                    
                    if (bid == bid_hack)//Хак
                        Console.WriteLine($"Ля ты знаток, но ставка будет = {bid_hack}");

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
                    Console.Clear();
                }

                //Вывод табло
                for (int n = 0; n < 2; n++)
                {
                    Console.Clear();
                    Console.WriteLine(kazino);
                    //Хак
                    if (bid == bid_hack) Console.WriteLine($"Ля ты знаток, но ставка будет = {bid_hack}");

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
                double Win;
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
                        Console.WriteLine("\n\nСочувствуем, но вам не повезло\nПопробуйте еще раз");
                    }
                }
            }
        }
    }
}
