Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "лилия")
{
    Console.WriteLine("Ура, это же Лилия");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}