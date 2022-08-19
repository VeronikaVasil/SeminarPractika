//Задача 27: Напишите программу, 
//которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());

int sum = 0;

while (N > 0)
{
    int number = N % 10;
    N = N / 10;
    sum = sum + number;
}
Console.WriteLine($"Сумма цифр в числе равна: {+sum}");

Console.ReadLine();





