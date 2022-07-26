
string[] myArray = {"Hi!", "8760", "How", "ball", "are", "1938", "you", "?"};
int elementLength = 3;
Console.WriteLine();
PrintArray(FindShortElements(myArray, elementLength));
Console.WriteLine();


string[] FindShortElements(string[] inputArray,int number)
{
    int CountShortElements(string[] inputArray)
    {
        int result = 0;
        for(int i = 0; i < inputArray.Count(); i++)
        {
            if(inputArray[i].Length <= number) result++;
        }
    return result;
    }

    string[] outputArray = new string[CountShortElements(inputArray)];
    int index = 0;
    for(int i = 0; i < inputArray.Length; i++)
    {
        if(inputArray[i].Length <= number)
        {
            outputArray[index] = inputArray[i];
            index += 1;
        }
    }
    return outputArray;
}

void PrintArray(string[] inputArray) 
{
   for(int i = 0; i < inputArray.Length; i++)
  Console.Write(inputArray[i] + " ");
}
