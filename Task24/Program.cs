﻿// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите целое положительное число");
int N = Convert.ToInt32(Console.ReadLine());

if(N <= 0)
{
    Console.WriteLine("Некорректный ввод");
    return;
}

int sumNumbers = SumNumbers(N);
Console.WriteLine($"{N} -> {sumNumbers}");
// Program.SumNumbers(number)

int SumNumbers(int num)
{
   int sum = 0;
   for (int i = 1; i <= num; i++)
   {
        checked     //Проверка переполнения 
        {
            sum = sum + i; //sum += i
        } 
   }
   return sum;
}

