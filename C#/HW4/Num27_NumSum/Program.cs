Console.WriteLine("Введите число:");
        int number = int.Parse(Console.ReadLine());

        int sum = 0;
        int temp = number;

        while (temp != 0)
        {
            sum += temp % 10;
            temp /= 10;
        }

        Console.WriteLine("Сумма цифр числа: " + sum);