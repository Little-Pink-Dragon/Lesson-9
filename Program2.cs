Console.Write("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = M; i <= N; i++)
{
    sum = sum + i;
}
Console.Write($"M = {M}, N = {N} => {sum}");