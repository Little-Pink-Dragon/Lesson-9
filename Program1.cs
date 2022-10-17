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
if (N >= M)
{
    Console.Write($"Все натуральные числа от {M} до {N} -> (");
    Console.Write(NaturalNumber(M, N));
    int NaturalNumber(int M, int N)
    {
        if (M == N)
            return M;
        else
            Console.Write($"{NaturalNumber(M, N - 1)}, ");
        return N;
    }
    Console.Write(")");
}
else
{
    Console.Write($"Все натуральные числа от {M} до {N} -> (");
    Console.Write(NaturalNumber(M, N));
    int NaturalNumber(int M, int N)
    {
        if (M == N)
            return M;
        else
            Console.Write($"{NaturalNumber(M, N + 1)}, ");
        return N;
    }
    Console.Write(")");
}
