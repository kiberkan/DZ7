// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int [,] CreatinRandomArray(int minValue = 1,int maxValue = 9)
{
    Console.WriteLine("Введите кол-во rows");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во columns");
    int columns = Convert.ToInt32(Console.ReadLine());
    if (rows > 0 || columns > 0)
    {
        int[,] arr = new int[rows,columns];
        var rnd = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
            arr[i, j] = rnd.Next(minValue,maxValue + 1);
            }
        }
        return arr;
    }
    else
    {
        System.Console.WriteLine("Введите длину масива (Целое и положительное число)");
        int[,] arr = new int [0,0];
        return arr;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void AvgElementСolumn(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.Write($"{sum / array.GetLength(0)}; ");
    }
}


int[,] array = CreatinRandomArray();
PrintArray(array);
AvgElementСolumn(array);