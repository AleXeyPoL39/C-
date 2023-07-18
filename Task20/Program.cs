// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату x1 точки А");
int x1A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y1 точки A");
int y1A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x2 точки B");
int x2B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y2 точки B");
int y2B = Convert.ToInt32(Console.ReadLine());

double result = Distance(x1A, y1A, x2B, y2B);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками: {resultRound}");


double Distance(int x1,int y1, int x2, int y2)
{
    int cat1 = x2 - x1;
    int cat2 = y2 - y1;
    double dist = Math.Sqrt(cat1 * cat1 + cat2 * cat2);
    return dist;
}
