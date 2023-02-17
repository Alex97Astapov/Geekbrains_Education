Console.Clear();
Console.WriteLine("Введите число: ");
string value = Console.ReadLine();
int number = Convert.ToInt32(value);

if ( number < 99 ) {
   Console.WriteLine  ($"{number} - нет третьего числа");
}
while (number > 999) {
   number = number / 10;
}
if (99 < number ) {
   number = number % 10;
   Console.WriteLine($"{number} - третье число");
}
