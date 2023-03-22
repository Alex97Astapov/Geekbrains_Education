// Задача 64: Задайте значение N.
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int PrintNumber(int a, int b)
{
   if (a == b) return a;
   else Console.Write($"{PrintNumber(a, b + 1)}  ");
   return b;
}


Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a < 1)
{
   Console.WriteLine("Ввдите положительное число!");
   return;
}
PrintNumber(a, 0);
