// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.WriteLine("Введите кординаты точки");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординаты точки");
Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

// if (xCoordinate > 0 && yCoordinate > 0)
// {
//     Console.WriteLine("Указанные координаты соответсвуют четверти 1");
// }
// else if (xCoordinate < 0 && yCoordinate < 0)
// {
//     Console.WriteLine("Указанные координаты соответсвуют четверти 3");
// }
// else if (xCoordinate > 0 && yCoordinate < 0)
// {
//     Console.WriteLine("Указанные координаты соответсвуют четверти 2");
// }
// else if (xCoordinate > 0 && yCoordinate > 0)
// {
//     Console.WriteLine("Указанные координаты соответсвуют четверти 4");
// }
// else
// {
//     Console.WriteLine("Введены не корректные координаты");
// }

int quarter = Quarter(xCoordinate, yCoordinate);
string result = quarter > 0 
            ? $"Указанные координаты соответсвуют четверти {quarter}"
            : "Введены некорректные координаты";

Console.WriteLine(result);

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 2;
    if (x < 0 && y > 0) return 4;
    return 0;
}