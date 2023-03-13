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

void Number(int num, int[,] Iarray)
{
   for (int i = 0; i < Iarray.GetLength(0); i++)
   {
      for (int j = 0; j < Iarray.GetLength(1); j++)
      {
         if (num == Iarray[i, j])
         {
            Console.WriteLine($"Значение {num}-->({i};{j})");
         }
         return;
         if (num != Iarray[i, j])
         {
            Console.WriteLine($"Значения {num} в массиве нет");
         }
      }
   }
}

Console.WriteLine("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбиков: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Number(n, array);