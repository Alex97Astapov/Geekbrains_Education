int[,,] GetArray(int min, int max)
{
   int[,,] res = new int[2, 2, 2];
   for (int i = 0; i < 2; i++)
   {
      for (int j = 0; j < 2; j++)
      {
         for (int k = 0; k < 2; k++)
         {
            res[i, j, k] = new Random().Next(min, max + 1);
         }
      }
   }
   return res;
}

void PrintArrat(int[,,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write($"({i}) ({j})");
         for (int k = 0; k < array.GetLength(2); k++)
         {
            Console.Write($"({k})={array[i, j, k]}; ");
         }
         Console.WriteLine();
      }
      Console.WriteLine();
   }
}

Console.Clear();
int[,,] Array = GetArray(10, 99);
PrintArrat(Array);
