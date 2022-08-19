// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int step = numberA;

for(int i = 1; i < numberB; i++)
{
step = step * numberA;
}

Console.WriteLine($"{numberA} ^ {numberB} = {+ step}");
