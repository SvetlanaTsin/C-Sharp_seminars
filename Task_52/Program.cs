/*
52. 
*/
Console.Clear();

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($" {matrix[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}

double[] AverageInColumns(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
       
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
           sum += matrix [i, j];
        }
        average [j] = Math.Round(sum / matrix.GetLength(0), 1);   
    }
    return average;
}

void PrintArray(double[] array)
{
    System.Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
}

int[,] matrix = new int[3, 3];
FillMatrix(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();

double[] userResult = AverageInColumns(matrix);
PrintArray(userResult);Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.