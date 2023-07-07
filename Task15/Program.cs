// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифры");
int number = Convert.ToInt32(Console.ReadLine());
string Day = number >= 1 && number <= 5 ? ("Нет") : ("Да");
Console.WriteLine(Day);



