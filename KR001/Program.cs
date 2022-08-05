
string[] arrayOne = new string[7] {"123" , "Sochi" , "VAU" , "world" , "046" , ":-)" , "Russia"};
string[] arrayTwo = new string[arrayOne.Length];
void SecondArray(string[] arrayOne, string[] arrayTwo)
{
    int count = 0;
    for (int i = 0; i < arrayOne.Length; i++)
    {
    if(arrayOne[i].Length <= 3)
        {
        arrayTwo[count] = arrayOne[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArray(arrayOne, arrayTwo);
PrintArray(arrayTwo);
