﻿//Задача 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Write("Введите число срок:  ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбиков:  ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,]GetArray (int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(10);
        }
    }
    return matrix;
}
 int[,] result = GetArray(rows, columns);
 
 void PrintArray (int[,]inputMatrix)
 {
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
      for (int m = 0; m < inputMatrix.GetLength(1); m++)
      {
        Console.Write(inputMatrix[i,m] + "\t"); // \t - Tab    
      }
      Console.WriteLine();
    }
 }
PrintArray (result);
Console.WriteLine();

void AverageOfColumns(int[,] array)
{
   
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        Console.Write($"{sum / array.GetLength(0)}  "); 
    }
}
AverageOfColumns(result);
Console.ReadLine();