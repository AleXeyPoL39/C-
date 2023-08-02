// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// A(n,m)=    m+1, если n=0
//            A(n-1,1), если n≠0, m=0
//            A(n-1,A(n,m-1)), если n>0,m>0

Console.WriteLine("Введите целое натуральное число m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое натуральное число n");
int n = Convert.ToInt32(Console.ReadLine());

static int Ack(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if (m == 0)
      return Ack(n - 1, 1);
    else
      return Ack(n - 1, Ack(n, m - 1));

}

void PrintAck(int m, int n)
{
    Console.Write(Ack(m, n)); 
}

PrintAck(m, n);