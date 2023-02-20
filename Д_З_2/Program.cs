
Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int i = 1;
int m = N;

if (N < 0)
{
   i = N;
   m = -N;
   N = -1;
}

int[] cube = new int[m];
for (int j = 0; i <= N; i++)
{
   cube[j] = i * i * i;
   j++;
}
for (int j = 0; j < m; j++)
{
   Console.WriteLine($"{cube[j]}");
}