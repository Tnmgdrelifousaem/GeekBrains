    Console.Write("Введите номер дня недели (1-7): ");
    int dayNumber = int.Parse(Console.ReadLine());

    if (dayNumber >= 1 && dayNumber <= 7)
    {
        if (dayNumber == 6 || dayNumber == 7)
        {
            Console.WriteLine("День является выходным");
        }
        else
        {
            Console.WriteLine("День не является выходным");
        }
    }
    else
    {
        Console.WriteLine("Некорректный номер дня недели");
    }