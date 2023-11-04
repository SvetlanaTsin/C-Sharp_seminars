/*
38. Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
*/
Console.Clear();

double[] GetRandomArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((new Random().Next(0, 20) + new Random().NextDouble()), 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}

double FindMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)  
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double CalcDifferenceBetweenMaxMin(double[] array)
{
    double result = FindMax(array) - FindMin(array);
    return result;
}

double[] userArray = GetRandomArray(9);
PrintArray(userArray);
System.Console.WriteLine();

double userResult = CalcDifferenceBetweenMaxMin(userArray);
System.Console.WriteLine($"Разность между максимальным и минимальным элементом: {userResult}");