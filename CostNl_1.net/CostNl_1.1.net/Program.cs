using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CostNl_1.net;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите свою Фамилию: ");
        string surname = Console.ReadLine();
        Console.Clear();
        Console.Write("Введите свое Имя: ");
        string name = Console.ReadLine();
        Console.Clear();
        Console.Write("Введите свое Отчество: ");
        string patronymic = Console.ReadLine();
        Console.Clear();

        Console.Write("Введите свой возраст: ");
        int age = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.Write("Введите свой Адрес (улица, дом, квартира): ");
        string address = Console.ReadLine();
        Console.Clear();

        Console.Write("Введите свой номер телефона: ");
        int number = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.Write("Введите свой рост в см: ");
        double growth = double.Parse(Console.ReadLine());
        Console.Clear();

        Console.Write("Введите свой вес в кг: ");
        double weight = double.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Вывод в консоль полученные данные\n");
        Console.WriteLine($"ФИО: {surname} {name} {patronymic}");
        Console.WriteLine($"Возрост: {age}");
        Console.WriteLine($"Адрес: {address}");
        Console.WriteLine($"Номер телефона: {number}");
        Console.WriteLine($"Рост: {growth} см");
        Console.WriteLine($"Вес: {weight} кг");
    }
}