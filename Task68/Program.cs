/* Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 9 */

Console.Write("Введите число M: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int M = Convert.ToInt32(Console.ReadLine());
int AckermannFunction(int M, int N)
{
 if (M == 0) return (N + 1);

 else if ((M > 0 || M < 0) && N == 0) return AckermannFunction(M - 1, 1);

 else if ((M > 0) && (N > 0)) return AckermannFunction(M - 1, AckermannFunction(M, N - 1));

    return AckermannFunction(M, N);
}

Console.WriteLine($"Функция Аккермана = {AckermannFunction(M, N)}");
