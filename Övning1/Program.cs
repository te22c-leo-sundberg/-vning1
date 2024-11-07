bool success = false;
string numInput;
int numOutput;
while (!success)
{
    numInput = Console.ReadLine();
    success = int.TryParse(numInput, out numOutput);
}