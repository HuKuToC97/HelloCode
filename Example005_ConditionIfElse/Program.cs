Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "никита")
{
    Console.WriteLine("Ура, это же НИКИТА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
