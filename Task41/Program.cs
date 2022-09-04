// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2      -> 2
// 1, -7, 567, 89, 223  -> 3
class StringConversion
{
 static void Main()
 {
  Console.Write("Введите элементы массива {M}, разделяя их пробелом:   ");
  
  int[] massiv = Array.ConvertAll(Console.ReadLine()!.Split(' '), Convert.ToInt32);
  Console.WriteLine();

  int count = 0;
  for (int i = 0; i < massiv.Length; i++)
   {
    if (massiv[i] > 0)
    {
     count++;
    }
   }
  Console.WriteLine($"Ввели {count} чисел больше 0");
 }
}
