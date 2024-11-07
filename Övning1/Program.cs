int correctNum = 0;
int guessNum;
string inputNum;
bool success = false;

while (!success)
{
    Console.WriteLine("Write a number that is to be guessed!");
    inputNum = Console.ReadLine();
    success = int.TryParse(inputNum, out correctNum);
}
success = false;
Console.Clear();

while(!success)
{
    Console.WriteLine("Guess what the number is!");
    inputNum = Console.ReadLine();
    success = int.TryParse(inputNum, out guessNum);

    if (guessNum > correctNum)
    {
        Console.WriteLine("Too high!");
        success = false;
    }
    else if (guessNum < correctNum)
    {
        Console.WriteLine("Too low!");
        success = false;
    }
    else
    {
        Console.WriteLine("Correct guess!");
    }

}

Console.ReadLine();