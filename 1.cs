Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);
int a = 1;
if(N<1)
{
  Console.WriteLine("Введено неположительное число");
}

int numbers = Numbers(N,a);

Console.WriteLine($"{numbers}");

int Numbers(int N, int a)
{
  if (N==a)
  {
    return N;
  }
  else 
  {
    Console.Write($"{Numbers(N, a+1)} ");
    return a;
  }
}