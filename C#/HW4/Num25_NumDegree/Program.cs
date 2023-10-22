Console.WriteLine("Введите число A:");
        int A = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите число B:");
        int B = int.Parse(Console.ReadLine());

        int result = 1;
        for (int i = 0; i < B; i++)
        {
            result *= A;
        }

        Console.WriteLine("Результат: " + result);
