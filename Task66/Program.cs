/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Write("Введите numberM: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите numberN: ");
int N = int.Parse(Console.ReadLine());

int Summ (int M, int N)
{
 if (M < N) return N + Summ(M, N - 1);
 return M;
}
int summ = Summ(M, N);
Console.Write($"SummNumbers = {summ} ");

