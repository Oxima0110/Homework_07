// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
//  в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.WriteLine("Введите размер двухмерного массива через пробел ");
int[] size = Console.ReadLine()!.Split().Select(int.Parse).ToArray();


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
            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i, j], 3}| ");
            else Console.Write($"{arr[i, j], 3} |");
        }
        Console.WriteLine();
    }
}

double[] ArithmeticMean(int[,] arr)
{
double[] array = new double[size[1]];
for (int i =0; i < size[1]; i++)
{
    for (int j = 0; j < size[0]; j++ )
    {
        array[i] = array[i] + arr[j,i];
    }
    array[i] = array[i]/size[0];
}
return array;
}

void PrintResult(double[] arr)
{
   Console.Write($"Среднее арифметическое каждого столбца: ");
   for (int i = 0; i < arr.Length; i++)
   {
    if (i <arr.Length - 1)  Console.Write($"{arr[i]}, ");
    else Console.Write($"{arr[i]}.");
   } 
}


int[,] arrayResult = CreateMatrixRndInt(size[0], size[1],1,10);
PrintMatrix(arrayResult);
double[] result = ArithmeticMean(arrayResult);
Console.WriteLine();
PrintResult(result);
