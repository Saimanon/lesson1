System.Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine()!);
int n_new = Math.Abs(n);
System.Console.WriteLine($"Цифры числа {n}:");
while (n_new > 10)
{
    System.Console.Write($"{n_new % 10},");
    n_new /= 10;
}
System.Console.Write(n_new);