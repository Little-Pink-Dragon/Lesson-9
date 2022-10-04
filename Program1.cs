Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {M}, N = {N} => '' ");
for (int i = M; i < N; i++)
{
    Console.Write($"{i}, ");
}
Console.Write($"{N} ''");