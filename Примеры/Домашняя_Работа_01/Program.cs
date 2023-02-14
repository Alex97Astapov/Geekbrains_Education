int a = new Random().Next(1,96); 
int b = new Random().Next(1,96);
int c = new Random().Next(1,96);
int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.Write("max = ");
Console.WriteLine(max);