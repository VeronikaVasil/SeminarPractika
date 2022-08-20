// Вывести третью цифру заданного числа или сообщить, что третьей цифры нет.

int a;

Console.Write("Введите число:" );


a = Convert.ToInt32(Console.ReadLine());


    if (a < 100)

        {
            Console.Write("Третьей цифры нет");
        }

     else if (a > 100)
         
        {
            string str = a.ToString();
            Console.Write("{0} третья цифра", (str[2]));
        }
        
Console.ReadLine();


