// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.WriteLine("Введите положительное целое число");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 0)
{
   TableSquare(N);
}
else
{
    Console.WriteLine("Ошибка ввода");
}

static void TableSquare(int Num)
{
    int count = 1;

    while (count <= Num)
    {
        Console.WriteLine($"{count, 3} {count * count, 5}");
        count++;
    }
}