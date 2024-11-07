string username = "";
string password = "";


while(username != "noname" || password != "nopass")
{
    Console.WriteLine("Write your username and password to procceed.");
    username = Console.ReadLine();
    password = Console.ReadLine();
}
Console.WriteLine("Welcome");
Console.ReadLine();