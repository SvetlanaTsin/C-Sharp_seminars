/*
36. Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
*/
Console.Clear();

int[] GetRandomArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}

int SumOddElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum = sum + array[i];
    }
     return sum;
}

int[] userArray = GetRandomArray(9);
PrintArray(userArray);
System.Console.WriteLine();

System.Console.WriteLine($"Сумма элементов с нечетными индексами: {SumOddElements(userArray)}");