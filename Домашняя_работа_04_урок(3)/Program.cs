int[] exp(int size)
{
   int[] col = new int[size];
   for (int i = 0; i < size; i++)
   {
      col[i] = new Random().Next(101);
   }
   return col;
}
Console.Clear();
int[] array = exp(8);
Console.WriteLine($"{String.Join(",", array)} --> [{String.Join(",", array)}]");
