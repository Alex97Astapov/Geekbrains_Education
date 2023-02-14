Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "aleksandr") {
   Console.WriteLine ("Good day, my Lord! ");
}
else
{
   Console.Write("Hello, ");
   Console.WriteLine(username);
}