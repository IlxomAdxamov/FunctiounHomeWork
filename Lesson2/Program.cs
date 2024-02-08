// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

using System;

class Program
{
    static void Main()
    {
        // Задаем размер массива
        int arraySize = 10;

        // Создаем массив случайных трехзначных чисел
        int[] numbersArray = GenerateRandomNumbers(arraySize);

        // Выводим содержимое массива
        Console.WriteLine("Сгенерированный массив:");
        PrintArray(numbersArray);

        // Подсчитываем количество четных чисел в массиве
        int evenCount = CountEvenNumbers(numbersArray);

        // Выводим результат
        Console.WriteLine($"Количество чётных чисел в массиве: {evenCount}");
    }

    // Метод для генерации массива случайных трехзначных чисел
    static int[] GenerateRandomNumbers(int size)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100, 1000); // Генерация случайного трехзначного числа
        }

        return array;
    }

    // Метод для вывода содержимого массива
    static void PrintArray(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }

    // Метод для подсчета количества четных чисел в массиве
    static int CountEvenNumbers(int[] array)
    {
        int count = 0;

        foreach (var number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }
}
