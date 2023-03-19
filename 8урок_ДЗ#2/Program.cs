// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int SumLineElements(int[,] array, int i)
{
   int sumline = array[i, 0];
   for (int j = 1; j < array.GetLength(1); j++)
   {
      sumline = sumline + array[i, j];
   }
   return sumline;
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

int MinSumLine = 0;
int sumline = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
   int TempSumLine = SumLineElements(array, i);
   if (sumline > TempSumLine)
   {
      sumline = TempSumLine;
      MinSumLine = 1;
   }
}
Console.WriteLine($"{MinSumLine + 1} - строка с меньшей суммой ({sumline}) элементов");