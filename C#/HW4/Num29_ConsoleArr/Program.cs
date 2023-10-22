int[] numbers = new int[8];

        Console.WriteLine("Введите 8 чисел:");

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Элементы массива:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($" {numbers[i]},");
        }
        Console.WriteLine(".");