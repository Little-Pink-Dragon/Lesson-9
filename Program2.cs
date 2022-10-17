int M = 0;
int N = 0;
while (true)
{
    Console.Write("Введите первое натуральное число: ");
    int m = Convert.ToInt32(Console.ReadLine());
    if (m > 0)

    {
        M = m;
        break;

    }
    else
    {
        Console.WriteLine("Вы ввели не натуральное число");
    }
}
while (true)
{
    Console.Write("Введите второе натуральное число число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n > 0)

    {
        N = n;
        break;

    }
    else
    {
        Console.WriteLine("Вы ввели не натуральное число");
    }
}
int SumNumbers(int M, int N)
{
    if (M == N)
        return N;
    return N + SumNumbers(M, N - 1);
}
Console.WriteLine($"Сумма элементов от {M} до {N} = {SumNumbers(M, N)}");