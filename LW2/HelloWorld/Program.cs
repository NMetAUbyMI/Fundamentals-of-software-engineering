using System;

class Program
{
    static void Main(string[] agrs)
    {
        // Запитуємо у користувача перше число
        Console.WriteLine("Введіть перше число: ");
        string input1 = Console.ReadLine();

        // Запитуємо у користувача друге число
        Console.WriteLine("Введіть друге число: ");
        string input2 = Console.ReadLine();

        // Конвертація введених значень у тип double
        double num1 = Convert.ToDouble(input1);
        double num2 = Convert.ToDouble(input2);

        // Виконання арифметичних операцій
        Console.WriteLine($"Сума: {num1 + num2}");
        Console.WriteLine($"Різниця: {num1 - num2}");
        Console.WriteLine($"Добуток: {num1 * num2}");

        // Обробка ділення на нуль
        if (num2 != 0)
        {
            Console.WriteLine($"Частка: {num1 / num2}");
        }
        else
        {
            Console.WriteLine("Помилка: ділення на нуль неможливе!");
        }
    }
}