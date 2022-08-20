//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int[] array = new int[4];
Random x = new Random();

for (int i = 0; i < 4; i++)
{
    array[i] = x.Next(-99, 100);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
int result = 0;
for (int i = 1; i < 4; i = i + 2)
{
    Console.Write(array[i] + " ");
    result = result + array[i];

}
Console.WriteLine(" — элементы массива с нечётным индексом ");

Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции, соcтавляет {result} ");



