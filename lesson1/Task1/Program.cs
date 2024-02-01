System.Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine()!);
int n_new = Math.Abs(n);
if (n_new % 7 == 0 && n_new % 23 == 0)
{
    System.Console.WriteLine($"Число {n} кратно 7 и 23 одновременно");
}
else
{
    System.Console.WriteLine($"Число {n}  не кратно 7 и 23 одновременно");
}