int[] GetArray(int size, int MinValue, int MaxValue)
{
   int[] res = new int[size];
   for (int i = 0; i < size; i++)
   {
      res[i] = new Random().Next(MinValue, MaxValue + 1);
   }
   return res;
}

int Sum(int[] array)
{
   int summa = 0;
   int size1 = array.Length;
   for (int j = 0; j < size1; j++)
   {
      if (j % 2 != 0) summa = summa + array[j];
   }
   return summa;
}
Console.Clear();
int[] startArray = GetArray(6, 1, 9);
Console.WriteLine($"{String.Join(",", startArray)} -->{Sum(startArray)}");