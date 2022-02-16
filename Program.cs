string[] workArray = FillArray();
Console.WriteLine(PrintArray(workArray));
int counter = CountStringSymbols(workArray);
Console.WriteLine(counter);

string[] FillArray()
{
    Console.WriteLine("Enter any strings separated by commas and/or spaces: ");
    string? enterSymbols = Console.ReadLine();
    if (enterSymbols == null) { enterSymbols = ""; };
    char[] separators = new char[] { ',', ' ' };
    string[] workArray = enterSymbols.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return workArray;
}

