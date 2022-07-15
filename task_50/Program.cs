// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.Clear();

Console.WriteLine("Введите размер двухмерного массива через пробел ");
int[] size = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
Console.WriteLine("Введите позицию элемента в двухмерном массиве через пробел ");
int[] data = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

int[,] CreateMatrixRndInt(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("|");
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j],3}| ");
            else Console.Write($"{arr[i, j],3} |");
        }
        Console.WriteLine();
    }
}

void Position(int[,] arr)
{
    // string str = String.Empty;
    if (data[0] < size[0] && data[1] < size[1]) Console.WriteLine($"Значение элемента = {arr[data[0], data[1]]}");
    else Console.WriteLine("Такого элемента нет");
}

int[,] arrayResult = CreateMatrixRndInt(size[0], size[1], 1, 20);
PrintMatrix(arrayResult);
Position(arrayResult);