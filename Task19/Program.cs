// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (IsPalindrome(number))
{
    Console.WriteLine("Число является палиндромом.");
}
else
{
    Console.WriteLine("Число не является палиндромом.");
}

static bool IsPalindrome(int number)
{
    string numberString = number.ToString();
    int length = numberString.Length;

    for (int i = 0; i < length / 2; i++)
    {
        if (numberString[i] != numberString[length - i - 1])
        {
            return false;
        }
    }

    return true;
}