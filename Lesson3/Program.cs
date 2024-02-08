// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

using System;

class Program
{
    static void Main()
    {
        // Задаем массив
        int[] originalArray = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Исходный массив:");
        PrintArray(originalArray);

        // Переворачиваем массив
        int[] reversedArray = ReverseArray(originalArray);

        Console.WriteLine("Перевернутый массив:");
        PrintArray(reversedArray);
    }

    // Метод для переворачивания массива
    static int[] ReverseArray(int[] array)
    {
        int length = array.Length;
        int[] reversedArray = new int[length];

        for (int i = 0; i < length; i++)
        {
            reversedArray[i] = array[length - 1 - i];
        }

        return reversedArray;
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
}
