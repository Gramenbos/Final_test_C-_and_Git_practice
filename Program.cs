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

string PrintArray(string[] array)
{
    string stringArray = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            stringArray += $"{array[i]}";
            break;
        }
        stringArray += ($"{array[i]}, ");
    }
    stringArray += "]";
    return stringArray;
}

int CountStringSymbols(string[] array)
{
    int counter = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            counter++;
        }
    }
    return counter;
}