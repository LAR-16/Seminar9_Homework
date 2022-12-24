int Akk(int a, int b)
{
    if (a == 0)
        return b + 1;
    else if (b == 0)
        return Akk(a - 1, 1);
    return Akk(a - 1, Akk(a, b - 1));
}


Console.Clear();
Console.Write("Введите 1-ое число: ");
int m = Convert.ToInt32(Console.ReadLine());
while (m < 0)
{
    Console.Write("Введите 1-ое число: ");
    m = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введите 2-ое число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 0)
{
    Console.Write("Введите 2-ое число: ");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(Akk(m, n));
