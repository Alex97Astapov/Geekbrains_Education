// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SorttoLover(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         for (int k = 0; k < array.GetLength(1) - 1; k++)
         {
            if (array[i, k] < array[i, k + 1])
            {
               int p = array[i, k + 1];
               array[i, k + 1] = array[i, k];
               array[i, k] = p;
            }
         }
      }
   }
}

void PrintArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write($"{array[i, j]} ");
      }
      Console.WriteLine();
   }
}

Console.WriteLine("Введите кол-во строк ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбиков: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
SorttoLover(array);
PrintArray(array);
