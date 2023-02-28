int[] GetArray(int size, int MinValue, int MaxValue)
{
   int[] res = new int[size];
   for (int i = 0; i < size; i++)
   {
      res[i] = new Random().Next(MinValue, MaxValue + 1);
   }
   return res;
}
int Min(int[] array)
{
   int min = array[0];
   int size1 = array.Length;
   for (int j = 1; j < size1; j = j + 1)
   {
      if (array[j] < min) min = array[j];
   }
   return min;
}

int Max(int[] array)
{
   int max = array[0];
   int size1 = array.Length;
   for (int j = 1; j < size1; j = j + 1)
   {
      if (array[j] > max) max = array[j];
   }
   return max;
}
Console.Clear();
int[] startArray = GetArray(6, -4, 10);
int dif = Max(startArray) - (Min(startArray));
Console.WriteLine($"Разница максимального и минимального числа в массиве {String.Join(",", startArray)} равна {dif}");