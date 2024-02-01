System.Console.WriteLine("Введите число x");
int x = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите число y");
int y = int.Parse(Console.ReadLine()!);
while (x == 0 || y == 0)
{   
    System.Console.WriteLine($"Числа {x} и {y} не должны быть равны 0");
    System.Console.WriteLine("Введите число x");
    x = int.Parse(Console.ReadLine()!);
    System.Console.WriteLine("Введите число y");
    y = int.Parse(Console.ReadLine()!);
}
if (x > 0 && y > 0)
{
    System.Console.WriteLine("Точка находится в 1 четверти");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine("Точка находится во 2 четверти");
}
else if (x < 0 && y < 0)
{
    System.Console.WriteLine("Точка находится в 3 четверти");
}
else
{
    System.Console.WriteLine("Точка находится в 4 четверти");
}