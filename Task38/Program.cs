// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

double [] array = CreateArrayRndDouble(6, 1, 100);
PrintArrayDouble(array);

void PrintArrayDouble(double[] arr, string sep = ", ", int round = 1)
{   
     Console.Write("["); 
    for (int i = 0; i < arr.Length; i++)
    {
        double num = Math.Round(arr[i], round);
        if (i < arr.Length - 1) Console.Write($"{num}{sep}");
        else Console.Write($"{num}");
    }
     Console.Write("]");
}

double max = FindMax(array);

double FindMax(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

double maxR = max;
maxR = Math.Round(maxR, 1);

double min = FindMin(array);

double FindMin(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

double minR = min;
minR = Math.Round(minR, 1);


double diff = Difference(array);

double Difference(double[] arr)
{
    diff = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        diff = max - min;
    }
    return diff;
}

double diffR = diff;
diffR = Math.Round(diffR, 1);
Console.WriteLine($"-> {maxR} - {minR} = {diffR}");

