Console.Clear();
int num = new Random().Next(1,8);
Console.WriteLine (num);
if (num == 6) {
Console.WriteLine ($"{num} - Выходной день");
}
if (num == 7) {
Console.WriteLine ($"{num} - Выходной день");
}
else
{
   Console.WriteLine ($"{num} - Не выходной день ");
}
