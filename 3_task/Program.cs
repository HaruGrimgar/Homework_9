/*Напишите программу вычисления функции 
Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int f_akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else
    { if ((m != 0) && (n == 0)) return f_akkerman(m - 1, 1);
      else return f_akkerman(m - 1, f_akkerman(m, n - 1));
    }
}

Console.WriteLine(f_akkerman(2,3));
Console.WriteLine(f_akkerman(3,2));