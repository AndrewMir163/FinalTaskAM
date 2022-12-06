string[] array1 = new string[5] {"888", "34523", "Gek", "brains", "001"};
string[] array2 = new string[array1.Length];

ArrayReforming(array1, array2);
PrintArray(array2);

void ArrayReforming(string[] array1, string[] array2)
{
    
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[i] = array1[i];
        }
    }
}


void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}
