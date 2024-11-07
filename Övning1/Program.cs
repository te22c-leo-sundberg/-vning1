string username = "";
string password = "";

Console.WriteLine("Write your username and password to procceed.");
while(username != "noname" || password != "nopass")
{
    username = Console.ReadLine();
    password = Console.ReadLine();
    if (username != "noname" || password != "nopass")
    {
        Console.WriteLine("Wrong username or password.");
    }
}
Console.WriteLine("Welcome");
Console.ReadLine();
//No name och no pass