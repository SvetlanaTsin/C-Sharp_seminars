/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
*/
Console.Clear();

int[] GetRandArray(int size)  
{
    int[] array = new int [size];  
    
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 100);     
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}
int[] UserArray = GetRandArray(8);
PrintArray(UserArray);

