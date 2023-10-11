Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username == "Маша")
{
    Console.WriteLine("Привет, красавица!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}