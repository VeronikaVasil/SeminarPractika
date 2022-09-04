/* Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.Write("Введите число столбцов I матрицы и строк II матрицы: ");
int ColumnsRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число строк I матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов II матрицы: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] GetArray(int rows, int columns)
{
    int [,] array = new int [rows, columns];
    Random randomNumbers = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomNumbers.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int [,] array)
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

int [,] ArrayMultiply(int [,] arrayFirst, int [,] arraySecond)
{
    int arraySum = 0;
    int [,] arrayThird = new int [arrayFirst.GetLength(0), arraySecond.GetLength(1)];
    for (int i = 0; i < arrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arraySecond.GetLength(1); j++)
        {
            for (int k = 0; k < arrayFirst.GetLength(1); k++)
            {
                arraySum = arraySum + (arrayFirst[i,k] * arraySecond[k,j]);
            }
        arrayThird[i, j] = arraySum;
        arraySum = 0;
        }
    }
    return arrayThird;
}

int [,] firstArray = GetArray(rows, ColumnsRows);
int [,] secondArray = GetArray(ColumnsRows, columns);
Console.WriteLine($"I матрица состоит из({rows}) строк и ({ColumnsRows}) столбцов:");
PrintArray(firstArray);
Console.WriteLine();
Console.WriteLine($"II матрица состоит из ({ColumnsRows}) строк и ({columns}) столбцов:");
PrintArray(secondArray);
int [,] thirdArray = ArrayMultiply(firstArray, secondArray);
Console.WriteLine();
Console.WriteLine($"Произведение матриц = ({rows}) строк и ({columns}) столбцов:");
PrintArray(thirdArray);
Console.WriteLine();
Console.ReadLine();