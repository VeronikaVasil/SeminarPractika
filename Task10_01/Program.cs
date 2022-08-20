// Принять на вход трёхзначное число и на выходе показать 1,2,3 цифры этого числа.

Console.Write("Введите трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string str = threeDigitNumber.ToString();
Console.WriteLine("Первая цифра этого числа: {0} ", (str[0]));
Console.WriteLine("Bторая цифра этого числа: {0} ", (str[1]));
Console.WriteLine("Третья цифра этого числа: {0} ", (str[2]));


