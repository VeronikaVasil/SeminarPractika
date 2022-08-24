// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] arrayRealNumbers = new double[8];
Random rand = new Random();
Console.Write("Это массив: ");

for (int i = 0; i < arrayRealNumbers.Length; i++)
{
    arrayRealNumbers[i] = rand.Next(1, 99);

    Console.Write(arrayRealNumbers[i] + "  ");
}
Console.WriteLine();

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

for (int i = 0; i < arrayRealNumbers.Length; i++)
 {
    if (maxNumber < arrayRealNumbers[i])
    {
        maxNumber = arrayRealNumbers[i];
    }
 }  
for (int j = 0; j < arrayRealNumbers.Length; j++)
 {
    if (minNumber > arrayRealNumbers[j])
    {
        minNumber = arrayRealNumbers[j];
    }
 }

double result = maxNumber - minNumber;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {maxNumber} - {minNumber} = {result}");
