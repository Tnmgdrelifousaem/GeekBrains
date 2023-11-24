using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        int sum = SumNumbers(m, n);

        Console.WriteLine("Сумма натуральных чисел в промежутке от {0} до {1} равна {2}", m, n, sum);

        Console.ReadKey();
    }

    static int SumNumbers(int m, int n)
    {
        if (m == n)
            return m;
        else if (m < n)
            return m + SumNumbers(m + 1, n);
        else
            return n + SumNumbers(n + 1, m);
    }
}
