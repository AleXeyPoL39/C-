// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int [] arr = new int[size];
    Random rnd = new Random ();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
    return arr;
}

void PrintArray (int[] arr, string sep = ", ")
{
    Console.Write("["); 
   for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}{sep}");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int [] array = CreateArrayRndInt(4, 1, 99);
PrintArray(array);

int sum = SumOddPositioNum(array);
Console.WriteLine($"-> {sum}");


int SumOddPositioNum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
         sum += array[i];
    }
    return sum;
}

