// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.WriteLine("Введите размер двухмерного массива через пробел ");
int[] data = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

double[,] CreateMatrixRndInt(int min, int max)
{
    double[,] arr = new double[data[0], data[1]];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToDouble(rnd.Next(min, max) / 10.0);
        }
    }
    return arr;
}

void PrintMatrix(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],5}| ");
            else Console.Write($"{arr[i, j],5} |");
        }
        Console.WriteLine();
    }
}


double[,] arrayResult = CreateMatrixRndInt(-100, 100);
PrintMatrix(arrayResult);