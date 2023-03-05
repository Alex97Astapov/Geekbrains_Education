int Numbers(string[] array)
{
   int res = 0;
   int[] array1 = new int[array.Length];
   for (int i = 0; i < array1.Length; i++)
   {
      int a = int.Parse(array[i]);
      array1[i] = a;
      if (array1[i] > 0)
      {
         res++;
      }
   }
   return res;
}
Console.Clear();
Console.WriteLine("Введите несколько чисел через пробел: ");
string[] st = Console.ReadLine().Split(' ');
Console.WriteLine(Numbers(st));