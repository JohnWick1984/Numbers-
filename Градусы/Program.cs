using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("1. Перевести из Фаренгейта в Цельсий");
        Console.WriteLine("2. Перевести из Цельсия в Фаренгейт");

        int choice;
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            double temperature, convertedTemperature;

            switch (choice)
            {
                case 1:
                    Console.Write("Введите температуру в Фаренгейтах: ");
                    if (double.TryParse(Console.ReadLine(), out temperature))
                    {
                        convertedTemperature = (temperature - 32) * 5 / 9;
                        Console.WriteLine($"Температура в Цельсиях: {convertedTemperature:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Введено некорректное значение температуры.");
                    }
                    break;
                case 2:
                    Console.Write("Введите температуру в Цельсиях: ");
                    if (double.TryParse(Console.ReadLine(), out temperature))
                    {
                        convertedTemperature = (temperature * 9 / 5) + 32;
                        Console.WriteLine($"Температура в Фаренгейтах: {convertedTemperature:F2}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Введено некорректное значение температуры.");
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка: Выбрана неверная операция.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Ошибка: Введена некорректная операция.");
        }
    }
}
