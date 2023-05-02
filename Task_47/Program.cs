// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateRandomArray()
{
    Console.WriteLine("Введите кол-во rows");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во columns");
    int columns = Convert.ToInt32(Console.ReadLine());
    if (rows > 0 || columns > 0)
    {
        double[,] arr = new double[rows, columns];
    
        Random rnd = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
            arr[i, j] = rnd.NextDouble()*10;
            arr[i, j] = Math.Round(arr[i, j],1);
            }
        }
        return arr;
    }
    else
    {
        double[,] arr = {};
        System.Console.WriteLine("Вы ввели некоректную длину масива");
        return arr;
    }
   
    
}

void PrintArray(double[,] array)
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


double[,] arr = CreateRandomArray();
PrintArray(arr);