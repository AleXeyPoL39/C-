// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату x1 точки А");
int x1A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y1 точки A");
int y1A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z1 точки А");
int z1A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x2 точки B");
int x2B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y2 точки B");
int y2B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z2 точки B");
int z2B = Convert.ToInt32(Console.ReadLine());

double result = Distance(x1A, y1A, z1A, x2B, y2B, z2B);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками: {resultRound}");


double Distance(int x1,int y1, int z1, int x2, int y2, int z2)
{
    int Xdiff = x2 - x1;
    int Ydiff = y2 - y1;
    int Zdiff = z2 - z1;
    double dist = Math.Sqrt(Xdiff * Xdiff + Ydiff * Ydiff + Zdiff * Zdiff);
    return dist;
}

