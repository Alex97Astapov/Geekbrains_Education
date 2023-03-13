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

void Number(int x, int y, int[,] Iarray)
{
   x = Iarray.GetLength(0) - 1;
   y = Iarray.GetLength(1) - 1;
   if (0 <= x && x <= Iarray.GetLength(0) && 0 <= y && x <= Iarray.GetLength(1))
   {
      Console.WriteLine($"В этой точке находится число:{Iarray[x, y]}");
   }
   else
   {
      Console.WriteLine($"Такой позиции в массиве нет");
   }
}


Console.WriteLine("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбиков: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты x: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y: ");
int b = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
Number(a, b, array);
