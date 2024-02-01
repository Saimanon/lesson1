int n = int.Parse(Console.ReadLine()!);
int n_new = Math.Abs(n);
if (n_new < 100)
{
    System.Console.WriteLine("Такой цифры нет");
}
else
{

    System.Console.WriteLine($"{n_new % 1000 / 100}");
}
