int[] Array(int[] mas)
{
   for (int i = 0; i < mas.Length; i++)
   {
      if (mas[i] < 0)
      {
         mas[i] = mas[i] * (-1);
      }
      if (mas[i] > 0)
      {
         mas[i] = mas[i] * (-1);
      }
   }
   return mas;
}

int[] array = { 1, 2, -3, 4, -5 };
Console.WriteLine($"[{Array(array)}]");