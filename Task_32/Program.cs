/* 
32. Напишите программу замены элементов массива: положительные элементы замените на 
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/
Console.Clear();

int TakeNumber(string message)  
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GetRandomArray(int start, int end, int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

void PrintArray(int[] array) 
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            System.Console.Write(", ");
        }   
    }
    System.Console.Write("] -> ");

    for (int i = 0; i < array.Length; i++)
    {
          array[i] = array[i] * -1;
    }

    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            System.Console.Write(", ");
        }   
    }
    System.Console.WriteLine("]");
    System.Console.WriteLine();

}


    

int userArraySize = TakeNumber("Please enter array size: ");
int userArrayStart = TakeNumber("Please enter array start number range: ");
int userArrayEnd = TakeNumber("Please enter array end number range: ");

int[] userArray = GetRandomArray(userArrayStart, userArrayEnd, userArraySize);
PrintArray(userArray);