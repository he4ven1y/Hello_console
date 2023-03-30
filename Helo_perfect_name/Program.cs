Console.Write("Введите имя пользователя, ");
string username = Console.ReadLine();

if(username.ToLower() == "рома")
{
    Console.WriteLine("Ура, это же Рома");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}