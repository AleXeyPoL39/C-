// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое натуральное число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое натуральное число N");
int n = Convert.ToInt32(Console.ReadLine());

int sum = SumNaturalNumbers(m, n) + n;
Console.WriteLine($"Сумма натуральных чисел от {m} до {n}: {sum}");

static int SumNaturalNumbers(int start, int end)
{
    if (start == end)
        return 0;
    else 
        return start + SumNaturalNumbers(start + 1, end);
}

