// Ввести число и определить, является ли оно четным или нечетным

int x;
 
            Console.Write("Введите число: ");
 
            x = Convert.ToInt32(Console.ReadLine());
 
            if (x % 2 == 0)
 
            {
 
                Console.Write("Введенное число является четным");
 
                Console.Read();
 
            }
 
            else
 
            {
 
                Console.Write("Введенное число нечетное");
 
                Console.Read();
 
            }
            