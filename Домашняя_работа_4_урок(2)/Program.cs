int[] exp(int size)
{
   int[] col = new int[size];
   for (int i = 0; i < size; i++)
   {
      col[i] = new Random().Next(10);
   }
   return col;
}

int exp2(int[] collection)
{
   int sum = 0;
   int b = collection.Length;
   int index = 0;
   while (index < b)
   {
      sum = collection[index] + sum;
      index++;
   }
   return sum;
}

Console.Clear();
int[] array = exp(3);
int summa = exp2(array);
Console.WriteLine($"Сумма элементов числа {String.Join("", array)} равна {summa}");