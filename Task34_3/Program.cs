// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[4];
Random x = new Random();

for (int i = 0; i < 4; i++)
{
    array[i] = x.Next(100,1000);
    if (array[i] % 2 == 0)
    {
    Console.WriteLine(array[i] + " ");
    }
    else if (array[i] % 2 == 1)
    Console.WriteLine();
}
int count;
count = 0;
for (int i = 0; i < 4; i++)
{
    if (array[i] % 2 == 0) count = count + 1;
}
Console.WriteLine($"Чётных элементов {count} в данном массиве");
Console.ReadLine();