// Ввести три числа и выдать максимальное из этих чисел

int a, b, c;

Console.WriteLine("Введите три числа: ");

a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());

if (b < a && a > c)

{
  Console.WriteLine("{0} максимальное число", a);
}

else if (a < b && b > c)
{
  Console.WriteLine("{0} максимальное число", b);
}

else if (a < c && c > b)
{
    Console.WriteLine("{0} максимальное число", c);
}

Console.ReadLine();


