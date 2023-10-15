
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number >= 100)
{
    while (number > 999)
    {
        number = number / 10;
    }
    int result = number % 10;
    Console.WriteLine($"Третья цифра: {result}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}