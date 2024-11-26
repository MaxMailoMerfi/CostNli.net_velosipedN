using System.Security.Cryptography;

namespace CostNl_2._2.net
{
    internal class Program
    {
        static void Main()
        {
            int number; string input; // задане число
            for (; ; )
            {

                Console.WriteLine("Числа Армстронга\n");

                for (; ; ) // Проверка int
                {
                    Console.Write("\nВведите верхний предел (N): ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int num))
                    {
                        number = int.Parse(input);
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("Числа Армстронга");
                    Console.WriteLine("Некорректный ввод");
                }
                Console.WriteLine($"\nЧисла Армстронга от 1 до {number} равны:");
                int j = 1;
                for (int i = 0; i < number; i++)
                {
                    int sum = 0;
                    int digits = i.ToString().Length; // обнаружение количества чисел
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

                Console.Write("\nНажмите любую клавишу для продолжения...");
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
