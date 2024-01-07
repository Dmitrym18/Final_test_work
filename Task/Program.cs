string[] sourceArray =  { "Hello", "2", "World", ":-)" };
string[] newArray = FormingNewArray(size:DeterminingSizeNewArray(sourceArray),array:sourceArray);
PrintArray(array:sourceArray);
PrintArray(array:newArray);

int DeterminingSizeNewArray(string[]array)
{
    int length = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3) 
    length++;
    return length;
}
string[] FormingNewArray(int size, string[] array)
{
    int position = 0;
    string[] threeArr = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            threeArr[position] = array[i];
            position++;
        }
    }
return threeArr;
}
void PrintArray(string[] array)
{
    Console.Write("[");
    Console.Write(string.Join(",",array));
    Console.Write("]");
    Console.WriteLine(); 
}