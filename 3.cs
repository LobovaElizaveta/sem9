Console.WriteLine("Введите число M ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N ");
int N = int.Parse(Console.ReadLine()!);

int Function = Akkerman(M, N);

Console.WriteLine($" M={M}, N={N}, A(M,N) = {Function}");

int Akkerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else
    if (N == 0 && M > 0)
    {
        return Akkerman(M - 1, 1);
    }
    else
    {
        return Akkerman(M - 1, Akkerman(M, N - 1));
    }
}