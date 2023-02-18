Console.Clear();
Console.Write("Введите значение Х1:  ");
double x1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение Y1:  ");
double y1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение Z1:  ");
double z1 = double.Parse(Console.ReadLine());

Console.Write("Введите значение Х2:  ");
double x2 = double.Parse(Console.ReadLine());

Console.Write("Введите значение Y2:  ");
double y2 = double.Parse(Console.ReadLine());

Console.Write("Введите значение Z2:  ");
double z2 = double.Parse(Console.ReadLine());

double b = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

Console.WriteLine($"b={b:f4}");
