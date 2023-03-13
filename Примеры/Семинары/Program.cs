int[,] GetArray(int m, int n, int minValue, int maxValue)
{
   int[,] res = new int[m, n];
   for (int i = 0; i < m; i++)
   {
      for (int j = 0; j < n; j++)
      {
         res[i, j] = new Random().Next(minValue, maxValue + 1);
      }
   }
   return res;
}

int Summa(int[,] Iarray)
{
   int sum = 0;
   for (int i = 0; i < Iarray.GetLength(0); i++)
   {
      for (int j = 0; j < Iarray.GetLength(1); j++)
      {
         if (i == j)
         {
            sum = Iarray[i, j] + sum;
         }
      }
   }
   return sum;
}

void PrintArray(int[,] Inarray)
{
   for (int i = 0; i < Inarray.GetLength(0); i++)
   {
      for (int j = 0; j < Inarray.GetLength(1); j++)
      {
         Console.Write($"{Inarray[i, j]} ");
      }
      Console.WriteLine();
   }
}

Console.WriteLine("Введите число столбиков: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число строк: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма = {Summa(array)}");

