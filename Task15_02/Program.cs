Console.Write("Введите число, обозначающее день недели: " );

int weekday = Convert.ToInt32(Console.ReadLine()); 


    if (weekday == 6 || weekday == 7)

    {
        Console.Write("Этот день является выходным"); 
    }
    
    else if ( weekday < 6)

    {
        Console.Write("Это рабочий день недели");
    }    

Console.ReadLine();


