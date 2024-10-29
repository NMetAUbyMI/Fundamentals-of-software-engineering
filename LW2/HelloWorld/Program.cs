using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            // Виводимо меню
            Console.WriteLine("Виберіть операцію:");
            Console.WriteLine("1. Додавання");
            Console.WriteLine("2. Віднімання");
            Console.WriteLine("3. Множення");
            Console.WriteLine("4. Ділення");
            Console.WriteLine("5. Вихід з програми");
            Console.Write("Ваш вибір: ");

            // Зчитуємо вибір користувача
            string choice = Console.ReadLine();

            // Якщо вибір - вихід, завершуємо програму
            if (choice == "5")
            {
                Console.WriteLine("Вихід з програми.");
                break;
            }

            // Запитуємо у користувача два числа
            Console.Write("Введіть перше число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть друге число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Виконання обраної операції
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Результат: {num1 + num2}");
                    break;
                case "2":
                    Console.WriteLine($"Результат: {num1 - num2}");
                    break;
                case "3":
                    Console.WriteLine($"Результат: {num1 * num2}");
                    break;
                case "4":
                    // Обробка ділення на нуль
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Результат: {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Помилка: ділення на нуль неможливе!");
                    }
                    break;
                default:
                    Console.WriteLine("Невірний вибір, спробуйте ще раз.");
                    break;
            }

            // Розділяємо результати для зручності
            Console.WriteLine(new string('-', 30));
        }
    }
}