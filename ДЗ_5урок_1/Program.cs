int[] GetArray(int size, int MinValue, int MaxValue)
{
   int[] res = new int[size];
   for (int i = 0; i < size; i++)
   {
      res[i] = new Random().Next(MinValue, MaxValue + 1);
   }
   return res;
}

int Number(int[] array)
{
   int count = 0;
   foreach (var item in array)
   {
      if (item % 2 == 0) count++;
   }
   return count;
}

int[] startArray = GetArray(5, 101, 999);
Console.WriteLine($"В массиве {String.Join(",", startArray)} {Number(startArray)} четных чисел");
