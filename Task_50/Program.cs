// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4


int [,] CreatinRandomArray(int minValue = 1,int maxValue = 10)
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


void FindIndexRowsAdnCols(int[,] arr)
{
Console.Write("Введите строку: ");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;

if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
{
Console.WriteLine("Элемент не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
}
Console.ReadKey();
}

int[,] arr = CreatinRandomArray();
PrintArray(arr);
FindIndexRowsAdnCols(arr);

