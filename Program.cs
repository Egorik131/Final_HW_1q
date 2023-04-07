string[] CreateArray(int size)
{
    string[] newArray = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} array element: ");
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}

void ShowArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}

string[] ArrayLessFour(string[] array)
{
    int limitElement = 3;
    int countElement = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= limitElement) countElement++;
    }
    
    int j = 0;
    string[] newArray = new string[countElement];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= limitElement)
        {
            newArray[j] = array[i];
            j++;
        } 
    }
    return newArray;
}

Console.Write("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] myArray = CreateArray(size);
string[] newArray = ArrayLessFour(myArray);
ShowArray(myArray);
Console.Write(" -> ");
ShowArray(newArray);