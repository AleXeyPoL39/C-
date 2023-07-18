// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое положительное число");
int N = Convert.ToInt32(Console.ReadLine());

if(N <= 0)
{
    Console.WriteLine("Некорректный ввод");
    return;
}

int factorial = Factorial(N);
Console.WriteLine($"{N} -> {factorial}");

int Factorial(int num)
{
   int fact = 1;
   for (int i = 1; i <= num; i++)
   {
        checked     
        {
            fact = fact * i;
        } 
   }
   return fact;
}