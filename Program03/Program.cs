// Ввести число и определить, является ли оно четным или нечетным

int numberA;
Console.Write("Введите число: ");
numberA = Convert.ToInt32(Console.ReadLine());
if (numberA % 2 == 0)
{
    Console.Write("Введенное число является четным");
    Console.Read();
}
else
{
    Console.Write("Введенное число нечетное");
    Console.Read();
}