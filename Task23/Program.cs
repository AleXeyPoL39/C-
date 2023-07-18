// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите положительное целое число");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 0)
{
   TableCube(N);
}
else
{
    Console.WriteLine("Ошибка ввода");
}

static void TableCube(int Num)
{
    int count = 1;

    while (count <= Num)
    {
        Console.WriteLine($"{count, 1} | {count * count * count}");
        count++;
    }
}