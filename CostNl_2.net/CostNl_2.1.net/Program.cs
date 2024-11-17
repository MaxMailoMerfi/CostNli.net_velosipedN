namespace CostNl_2._1.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int bid; int one, tuo, thre;
            int hack = 42; int bid_hack = -1; // читы (код, сколько бабок
            string kazino = "$Казино$"; //Название Которое будет сверху йобаного казино

            Console.WriteLine("Вас приветсвует йобаное казино");

            for (; ; )
            {
                for (; ; )
                {
                    Console.WriteLine("\nСделайте ставку то 5$ до 100$, з шагом 5$");
                    bid = int.Parse(Console.ReadLine());
                    if (((bid % 5 == 0) && (bid > 0) && (bid < 100)) || (bid == hack))
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
                    Console.WriteLine(kazino);
                    bid = bid_hack;
                    Console.WriteLine($"Ля ты криса но ставка будет = {bid_hack}");
                    one = 7;
                    tuo = 7;
                    thre = 7;
                }
                else //Рандом
                {
                    Console.WriteLine(kazino);

                    one = random.Next(1, 10);
                    tuo = random.Next(1, 10);
                    thre = random.Next(1, 10);
                }
                Console.WriteLine($"\n{one}{tuo}{thre}");
                double Win;
                //+++
                if ((one == tuo) && (one == thre))
                {
                    if (one == 7)
                    {
                        Win = bid_hack * 150 * 1.5;
                        Console.WriteLine($"\nДжекпот будет составлять = {Win}");
                    }
                    else
                    {
                        Win = bid * (one * 10) * 1.5;
                        Console.WriteLine($"Ля ты криса но ставка будет = {Win}");
                    }

                }
                else
                {
                    if ((one == tuo) || (one == thre))
                    {
                        if (one == 7)
                        {
                            Win = bid_hack * 15 * 1.25;
                            Console.WriteLine($"\nДжекпот будет составлять = {Win}");
                        }
                        else
                        {
                            Win = bid * one * 1.25;
                            Console.WriteLine($"Ля ты криса но ставка будет = {Win}");
                        }
                    }
                    if (tuo == thre)
                    {
                        if (tuo == 7)
                        {
                            Win = bid * 15 * 1.25;
                            Console.WriteLine($"\nДжекпот будет составлять = {Win}");
                        }
                        else
                        {
                            Win = bid * tuo * 1.25;
                            Console.WriteLine($"Ля ты криса но ставка будет = {Win}");
                        }
                    }
                }
            }
        }
    }
}
