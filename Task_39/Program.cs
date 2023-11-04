/*
39. Напишите программу, которая перевернет одномерный массив: 
посл элемент на первом месте, а первый элемент на последнем месте
*/
Console.Clear();

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
    System.Console.WriteLine("]");
}

int[] ReversArray(int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length/2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = temp;
    }
    return arr;
}

int[] userArray = GetRandomArray(0, 10, 7);
PrintArray(userArray);
System.Console.WriteLine();
int[] revesedArray = ReversArray(userArray);
PrintArray(revesedArray);