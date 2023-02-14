int a = new Random().Next(1,96); 
int b = new Random().Next(1,96);
int c = new Random().Next(1,96);
int d = new Random().Next(1,96); 
int i = new Random().Next(1,96);

int max = a;

if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (i > max) max = i;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(i);
Console.Write("max = ");
Console.WriteLine(max);