// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите целое положительное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;

     while (count <= N)
    {
       Console.Write($"{count * count * count} ");
       count ++;
    }
