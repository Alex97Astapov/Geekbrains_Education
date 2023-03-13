double[,] GetArray(int m, int n, int min, int max)
{
   double[,] res = new double[m, n];
   for (int i = 0; i < m; i++)
   {
      for (int j = 0; j < n; j++)
      {
         res[i, j] = Math.Round(new Random().NextDouble() * (max - min) + min, 1);
      }
   }
   return (res);
}
void PrintArray(double[,] InArray)
{
   for (int i = 0; i < InArray.GetLength(0); i++)
   {
      for (int j = 0; j < InArray.GetLength(1); j++)
      {
         Console.Write($"{InArray[i, j]} ");
      }
      Console.WriteLine();
   }
}

Console.WriteLine("Введите кол-во столбиков: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во строк: ");
int columns = int.Parse(Console.ReadLine());
double[,] array = GetArray(rows, columns, 4, 10);
PrintArray(array);

