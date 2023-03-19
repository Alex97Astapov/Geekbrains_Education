// Задача 58: Задайте две матрицы. 
// Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18// 

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

int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
   int[,] resarray = new int[array1.GetLength(1), array2.GetLength(1)];
   for (int i = 0; i < resarray.GetLength(0); i++)
   {
      for (int j = 0; j < resarray.GetLength(1); j++)
      {
         int sum = 0;
         for (int k = 0; k < array1.GetLength(1); k++)
         {
            sum = sum + array1[i, k] * array2[k, j];
         }
         resarray[i, j] = sum;
      }
   }
   return resarray;
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
int rows1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбиков: ");
int columns1 = int.Parse(Console.ReadLine());
int[,] array1 = GetArray(rows1, columns1, 0, 10);
PrintArray(array1);
Console.WriteLine();

Console.WriteLine("Введите кол-во строк ");
int rows2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбиков: ");
int columns2 = int.Parse(Console.ReadLine());
int[,] array2 = GetArray(rows2, columns2, 0, 10);
PrintArray(array2);
Console.WriteLine();

int[,] ResMatrix = MatrixMultiplication(array1, array2);
PrintArray(ResMatrix);