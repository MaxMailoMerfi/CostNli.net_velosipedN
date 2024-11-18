namespace CostNl_2._2.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Сделанно по заданию
            for (; ; )
            {
                int j = 0;

                Console.Write("Введите верхний предел (N): ");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine($"Числа Армстронга от 1 до {input} равны:");

                for (int i = 0; i < input; i++)
                {
                    int sum = 0;
                    int digits = i.ToString().Length;
                    int num = i;
                    while (num > 0)
                    {
                        int digit = num % 10;
                        sum += (int)Math.Pow(digit, digits);
                        num /= 10;
                    }
                    if (sum == i)
                    {
                        Console.WriteLine($"{j++}) {i}");
                    }
                }

                Console.WriteLine("\nНажмите любую клавишу для выхода...");
                Console.ReadKey();
                Console.Clear();
            }



            /*//Проверка, сколько будет в ручную
            for (; ; )
            {
                string input;
                int input_sahist;
                // Супер защита и ввод
                for (; ; )
                {
                    input = Console.ReadLine();
                    input_sahist = input.Replace(" ", "").Length;
                    if (!string.IsNullOrEmpty(input) && int.TryParse(input, out  int numper))
                    {
                        Console.WriteLine($"Строка состоит из {input_sahist} символов.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Строка нулевая, пустая или введено не число");
                    }
                }
                // Вычисление
                int sum = 0;
                int number = int.Parse(input);

                for (int i = 0;i < input_sahist; i++)
                {
                    int digit = number % 10;
                    sum += (int)Math.Pow(digit, input_sahist); // Возведение цифры в степень
                    Console.WriteLine($"{digit}^{input_sahist} = {sum}");
                    number /= 10;
                }
                Console.WriteLine(sum);

                Console.WriteLine("\nНажмите любую клавишу для выхода...");
                Console.ReadKey();
                Console.Clear();
            }*/
        }
    }
}
