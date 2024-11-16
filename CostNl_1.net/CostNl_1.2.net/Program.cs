namespace CostNl_1._2.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите данные о продукте:\n");
            Console.WriteLine("Название продукта: ");
            string productName = Console.ReadLine()?.Trim().ToUpper();
            Console.WriteLine("\nКоличество: ");
            double quantity = double.Parse(Console.ReadLine());
            Console.Write("\nЕдиницы измерения (шт., кг, литры и т.д.): ");
            string unit = Console.ReadLine()?.Trim().ToLower();
            Console.WriteLine("\nЦена за единицу: ");
            double price = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Информация о продукте:\n");
            Console.WriteLine($"Название: {productName}");
            Console.WriteLine($"Количество: {quantity} {unit}");
            Console.WriteLine($"Единицы измерения: {unit}");
            Console.WriteLine($"Цена за единицу: {price}");
        }
    }
}
