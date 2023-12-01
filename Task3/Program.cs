// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива. 

using System;
class Program
{
    static void Main()
    {
        // Массив из вещественных чисел с ненулевой дробной частью
        double[] array = { 1.5, 8.6, 11.7, 12.2, 14.9, 17.7, 28.4, 33.5, 2.8, 40.1 };

        // Максимальный и минимальный элементы массива
        double maxElement = array[0];
        double minElement = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
            }

            if (array[i] < minElement)
            {
                minElement = array[i];
            }
        }

        // Разница между максимальным и минимальным элементами
        double difference = maxElement - minElement;

        Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");
    }
}