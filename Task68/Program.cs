/* Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 9 */

Console.Write("Введите число M: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int m = Convert.ToInt32(Console.ReadLine());
int Ackerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
    if ((n != 0) && (m == 0))
        return Ackerman(n - 1, 1);
    else
        return Ackerman(n - 1, Ackerman(n, m - 1));
}
Console.WriteLine($"Функция Аккермана от введенных чисел равна: {Ackerman(n,m)}\n");
// {
//  if (M == 0) return (N + 1);

//  else if ((M > 0 || M < 0) && N == 0) return AckermannFunction(M - 1, 1);

//  else if ((M > 0) && (N > 0)) return AckermannFunction(M - 1, AckermannFunction(M, N - 1));

//     return AckermannFunction(M, N);
// }

// Console.WriteLine($"Функция Аккермана = {AckermannFunction(M, N)}");
