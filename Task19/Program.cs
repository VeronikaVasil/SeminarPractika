//  Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");

string DigitNumber = Console.ReadLine();

if (DigitNumber[0] == DigitNumber[4] && DigitNumber[1] == DigitNumber[3])
  
  {
    Console.WriteLine($"Ваше число: {DigitNumber} - палиндром.");
  }

  else Console.WriteLine($"Ваше число: {DigitNumber} - не является палиндромом.");
