// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Задайте количество строк двумерного массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"m = {m}, n = {n}.");

double[,] CreateMatrixRndInt(int rows, int columns, double min, double max)
{
    double[,] matrix = new double[m, n];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)  //matrix.GetLength(0) - опр. кол-во строк(i)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix, int round = 1)
{
    for (int i = 0; i < m; i++)  //matrix.GetLength(0) - опр. кол-во строк(i)
    {
        Console.Write("|");
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{Math.Round(matrix[i, j],round),6} ");
        }
        Console.WriteLine("|");
    }
}

double[,] array2d = CreateMatrixRndInt(m, n, -100, 100);
PrintMatrix(array2d);


