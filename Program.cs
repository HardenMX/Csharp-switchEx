/*
Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the value entered matches one of the three role options.
Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
Your solution should use the ToLower() method on the input value to ignore case.
If the value entered isn't a match for one of the role options, 
your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
*/

string? inputRead; 
string processedInputRead;
bool isValidEntry = false;

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");


do {
    inputRead = Console.ReadLine();

    if (inputRead != null)
    { 
    processedInputRead = inputRead.ToLower().Trim();
        switch (processedInputRead) 
        {
            case "administrator":
            case "user":
            case "manager":
                Console.WriteLine($"Your input value {inputRead.Trim()} has been accepted");
                isValidEntry = true;
                break;
            default:
                Console.WriteLine($"The role name that you entered, {processedInputRead} is not valid. Enter your role name (Administrator, Manager, or User)");
                break;  
        }
    } 
    else 
    {
        Console.WriteLine($"The role name that you entered, {inputRead} is not valid. Enter your role name (Administrator, Manager, or User)");
    }

} while (isValidEntry == false);

