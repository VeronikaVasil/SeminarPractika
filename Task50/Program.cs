//Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет (1 строчка, 7 столбец)

Console.Write("Bведите номер строки:  ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Bведите номер столбца:  ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] numbers = new int[5, 10];

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 100);
        }
    }
}
FillArrayRandomNumbers(numbers);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
PrintArray(numbers);

Console.WriteLine();
{
 if (r > numbers.GetLength(0) || c > numbers.GetLength(1))
  {
    Console.WriteLine($"Такого числа в массиве нет");
  }
 else
  {
    Console.WriteLine($"На строке [{r}] и столбце [{c}] находится элемент: {numbers[r - 1, c - 1]}");
  }
}
Console.WriteLine();
Console.ReadLine();
   
    