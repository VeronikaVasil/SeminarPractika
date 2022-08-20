// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int a;

Console.Write("Введите трёхзначное число: ");

a = Convert.ToInt32(Console.ReadLine());

string str = a.ToString();

Console.Write("{0} вторая цифра данного числа", (str[1]));

Console.ReadLine();
