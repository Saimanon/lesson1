System.Console.WriteLine("Введите число из отрезка [10, 99]");
int x = int.Parse(Console.ReadLine()!);
while (x < 10 || x > 99)
{   
    System.Console.WriteLine($"Число должно быть из отрезка [10, 99], введите повторно");
    x = int.Parse(Console.ReadLine()!);
}
int digit_1 = x / 10;
int digit_2 = x % 10;
if (digit_1 > digit_2)
{
    System.Console.WriteLine($"Максимальная цифра {digit_1}");
}
else
{
    System.Console.WriteLine($"Максимальная цифра {digit_2}");
}
