// Принять на вход трёхзначное число и на выходе показать вторую цифру этого числа.

Console.Write("Введи трёхзначное число: ");

int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

if (threeDigitNumber < 1000 && threeDigitNumber > 99)
{
int twoDigitNumber = threeDigitNumber / 10;
int result = twoDigitNumber % 10;
Console.WriteLine($"У числа {threeDigitNumber} вторая цифра {result}");
}

else 
{
    Console.WriteLine("Число не является трёхзначным");
}
Console.ReadLine();




