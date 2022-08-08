Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "ланочка")
{
    Console.WriteLine("Ура, это же ЛАНОЧКА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}