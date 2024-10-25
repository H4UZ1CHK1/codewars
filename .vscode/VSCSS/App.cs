using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество массивов в зубчатом массиве: ");
        int rows;
        while (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0)
        {
            Console.Write("Введите корректное положительное число: ");
        }

        int[][] jaggedArray = new int[rows][];
        Random rand = new Random();

        for (int i = 0; i < rows; i++)
        {
            Console.Write($"\nВведите количество элементов в массиве {i + 1}: ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size < 0)
            {
                Console.Write("Введите корректное неотрицательное число: ");
            }

            jaggedArray[i] = new int[size];

            // Заполнение массива случайными числами
            Console.WriteLine($"Случайные элементы для массива {i + 1}:");
            for (int j = 0; j < size; j++)
            {
                jaggedArray[i][j] = rand.Next(-10, 11); // Диапазон [-10, 10]
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nЗначения зубчатого массива:");
        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Массив {i + 1}: ");
            Array.ForEach(jaggedArray[i], elem => Console.Write(elem + " "));
            Console.WriteLine();
        }

        int[] sumArray = new int[rows];

        // Подсчет суммы элементов в каждом массиве
        for (int i = 0; i < rows; i++)
        {
            int sum = 0;
            Array.ForEach(jaggedArray[i], elem => sum += elem);
            sumArray[i] = sum;
        }

        Console.WriteLine("\nСуммы элементов каждого массива:");
        for (int i = 0; i < sumArray.Length; i++)
        {
            Console.WriteLine($"Сумма массива {i + 1}: {sumArray[i]}");
        }

        // Нахождение минимальной суммы
        int minSum = sumArray[0];
        for (int i = 1; i < sumArray.Length; i++)
        {
            if (sumArray[i] < minSum)
            {
                minSum = sumArray[i];
            }
        }

        Console.WriteLine($"\nМинимальная сумма среди всех массивов: {minSum}");
    }
}
