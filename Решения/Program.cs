Console.WriteLine("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбиков: ");
int columns = int.Parse(Console.ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
//FillArrayRandom(array);
PrintArray(array);
SortToLower(array);
Console.WriteLine();
PrintArray(array);


// Функция заполнения массива рандомно числами от 1 до 9
//void FillArrayRandom(int[,] array)
//{
// for (int i = 0; i < array.GetLength(0); i++)
//   {
//      for (int j = 0; j < array.GetLength(1); j++)
//      {
//         array[i, j] = new Random().Next(1, 10);
//      }
//   }
//}

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

// Функция сортировки элементов в строке двумерного массива, по убыванию
void SortToLower(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         for (int k = 0; k < array.GetLength(1) - 1; k++)
         {
            if (array[i, k] < array[i, k + 1])
            {
               int temp = array[i, k + 1];
               array[i, k + 1] = array[i, k];
               array[i, k] = temp;
            }
         }
      }
   }
}

// Функция вывода двумерного массива
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
void Summa(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         int sum = 0;
         sum = array[i, j] + sum;
         Console.WriteLine($"Сумма {i + 1} строки = {sum}");
      }
   }
}

