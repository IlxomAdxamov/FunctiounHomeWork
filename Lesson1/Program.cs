//Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите целое число или 'q' для завершения: ");
            string input = Console.ReadLine();

            // Проверяем, является ли введенная строка символом 'q'
            if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            // Пытаемся преобразовать введенную строку в целое число
            if (int.TryParse(input, out int number))
            {
                // Проверяем, является ли сумма цифр числа четной
                if (IsSumOfDigitsEven(number))
                {
                    Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Сумма цифр числа {number} нечётная.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q' для завершения.");
            }
        }
    }

    // Метод для определения четности суммы цифр числа
    static bool IsSumOfDigitsEven(int num)
    {
        int sum = 0;
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum % 2 == 0;
    }
}
