/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию
элементы каждой строки двумерного массива.*/

int [,] numbers = new int[5,10]; 
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 100);
        }
    }
}
FillArrayRandomNumbers(numbers);
Console.WriteLine("Это массив:");
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
void SortArrayRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int SortArrayRows = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = SortArrayRows;
                }
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Отсортированные по убыванию элементы строк массива:");
SortArrayRows(numbers);
PrintArray(numbers);
Console.WriteLine();