int[,] GetArray(int m, int n, int min, int max)
{
   int[,] res = new int[m, n];
   for (int i = 0; i < m; i++)
   {
      for (int j = 0; j < n; j++)
      {
         res[i, j] = new Random().Next(min, max + 1);
      }
   }
   return res;
}
double[] Average(int[,] Array)
{
   double[] result = new double[Array.GetLength(1)];
   for (int j = 0; j < Array.GetLength(1); j++)
   {
      for (int i = 0; i < Array.GetLength(0); i++)
      {
         result[j] = result[j] + Array[i, j];
      }
      result[j] = Math.Round(result[j] / Array.GetLength(0), 1);
   }
   return result;
}

void PrintArray(int[,] InArray)
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

Console.WriteLine("Введите кол-во строк ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбиков: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine();

Console.WriteLine($"Среднее арефметическое каждого cтолбика = {String.Join(" , ", (Average(array)))}");
