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


// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string message)
{
   Console.Write(message);
   int result = Convert.ToInt32(Console.ReadLine());
   return result;
}

int SumOfElements(int n, int m)
{
   if (n == m) return n;
   else return SumOfElements(n + 1, m) + n;
}

int n = Prompt("Input N: ");
int m = Prompt("Input M: ");

Console.WriteLine(SumOfElements(n, m));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


