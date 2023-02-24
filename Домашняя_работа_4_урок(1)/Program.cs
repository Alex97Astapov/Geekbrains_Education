int exp(int a, int b)
{
   int i = 1;
   int k = a;
   while (i < b)
   {
      k = k * a;
      i++;
   }
   return k;
}

Console.Clear();
Console.WriteLine("Введите число а: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"Число {a} в степени {b} -> {exp(a, b)}");
