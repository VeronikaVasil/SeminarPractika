// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int threeDigitNumber;
Console.Write("Введите трёхзначное число: ");

threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string str = threeDigitNumber.ToString();

Console.Write($"{(str[1])} вторая цифра данного числа");
Console.ReadLine();