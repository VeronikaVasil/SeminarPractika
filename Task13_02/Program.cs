// Вывести третью цифру заданного числа или сообщить, что третьей цифры нет.

Console.Write("Введите число:" );

 int digitnumber = Convert.ToInt32(Console.ReadLine());

    if (digitnumber < 100)
        {
            Console.Write("Третьей цифры нет");
        }
     else if (digitnumber > 100)
        {
            string stringnumber = Convert.ToString(digitnumber);
            Console.Write("{0} третья цифра", (stringnumber[2]));
        }

Console.ReadLine();


