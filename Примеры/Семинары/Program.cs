int[,] Getarray(int m, int n, int min, int max)
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


void Elements(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         if (array[i, j] == 0)
         {
            int a = 0;
            a = array[i, j] + 1;
            Console.WriteLine($"0 встречается {a} раз");
            return;
         }
      }
   }
}

void PrintArray(int[,] Iarray)
{
   for (int i = 0; i < Iarray.GetLength(0); i++)
   {
      for (int j = 0; j < Iarray.GetLength(1); j++)
      {
         Console.Write($"{Iarray[i, j]}  ");
      }
      Console.WriteLine();
   }
}

Console.WriteLine("Vvedite col-vo strok: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Vvedite col-vo stolbikov: ");
int columns = int.Parse(Console.ReadLine());
int[,] Array = Getarray(rows, columns, 0, 4);
PrintArray(Array);
Console.WriteLine();
Elements(Array);

