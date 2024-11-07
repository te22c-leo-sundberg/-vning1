string number = "";
int intNum;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Write a number for me");
    number = Console.ReadLine();
    bool success = int.TryParse(number, out intNum);
    if (intNum > 5)
    {
        Console.WriteLine("The number is greater than 5!");
    }
}
Console.ReadLine();