// Найти вторую цифру введённого числа

Console.Write("Введите число ");
int k = Convert.ToInt32(Console.ReadLine());
{
    while (k >= 100) k /= 10;
    int result = k % 10;
    Console.WriteLine($"Second number is {result}"); 
}
Console.ReadLine();

