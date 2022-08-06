// Ввести число N, а на выводе показать все четные числа от 1 до N

Console.WriteLine("Введите число N: ");

int numberN = Convert.ToInt32(Console.ReadLine());
    
    for (int i = 1;  i <= numberN; i++)

    {
        if (i % 2 == 0) 

        {
            Console.Write(i + " ");
        }

    }

    Console.ReadLine();
