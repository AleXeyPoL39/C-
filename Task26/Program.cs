// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

int result = LengthNumber(N);

Console.WriteLine($"{N} -> {result}");

int LengthNumber(int num)
{
    int count = 0;
    while (num != 0)
    {
        num = num / 10;
        count ++;
    }
    return count == 0 ? 1 : count; //если count равно 0 то 1 иначе count
}

