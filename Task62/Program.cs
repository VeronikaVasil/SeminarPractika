/* Задача 62. Напишите программу, 
которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[size, size]; // объявляем массив

int num = 1; // Начинаем счёт с единицы, расположенной по индексу [0,0]
int i = 0;
int j = 0;

while (num <= size * size) // Следующие операции будут производиться до тех пор, пока 4*4=16 :
{
    numbers[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j; // выводится значение j после выполнения операции сложения 
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1) // двигаемся в обратном направлении по строке
        --j;
    else
        --i;                            // и в обратном направлении вверх по столбцу
    ++num;
}

PrintArray(numbers);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " \t ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
Console.ReadLine();