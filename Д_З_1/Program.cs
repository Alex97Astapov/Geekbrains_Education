Console.Clear();
Console.Write("Введите любое пятизначное число: ");
int i = int.Parse(Console.ReadLine());
int a = i / 10000;
int a1 = i % 10;
int a2 = (i / 1000) % 10;
int a3 = (i % 100) / 10;

if (i < 10000 || i > 99999)
{
   Console.WriteLine($"Число {i} - должно быть пятизначным.  ");
}

else if (a == a1 & a2 == a3)
{
   Console.WriteLine($"Число {i} - является палиндромом  ");
}
else
{
   Console.WriteLine($"Число {i} - не является палиндромом  ");
}