Console.WriteLine("Введите число M ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма элементов {FindSum(M,N)}");

int FindSum(int M, int N)
{
  if( N==M)
  {
    return N;
  }
  return N + FindSum(M, N-1);
}