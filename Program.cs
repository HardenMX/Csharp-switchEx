
string? readInput;
bool validEntry = false;
int numericValue = 0;
bool validNumber = false;

Console.WriteLine("Please input an integer value btetween 5 and 10");

do
{
    readInput = Console.ReadLine();
    if (readInput != null)
    {
        validNumber = int.TryParse(readInput, out numericValue);
        if (numericValue > 4 && numericValue < 11)
        {
            validEntry = true;
        }
        else 
        {
            Console.WriteLine("Error, please input an integer value between 5 and 10");
        }
    }

} while (validEntry == false);

Console.WriteLine($"Thanks for inputting {readInput}, a correct number");