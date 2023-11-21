/*
56.  Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
*/
Console.Clear();
int[,] matrix = new int[3, 2];

void FillMatriх(int[,] matrix)
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
            System.Console.Write(matrix[i, j]);
            if (j < matrix.GetLength(1) - 1)
            {
                System.Console.Write("\t");
            }
        }
        System.Console.WriteLine();
    }
}

int SumOfRow(int[,] matrix, int row)
{   
    int rowSum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        rowSum += matrix [row, j];
    }  
    return rowSum;
}   

int[] MinimumSumRow(int[,] matrix)
{
    int[] RowNumberAndSum = new int[2];
    RowNumberAndSum[1] = SumOfRow(matrix, RowNumberAndSum[0]);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (RowNumberAndSum[1] > SumOfRow(matrix, i))
        {
            RowNumberAndSum[0] = i;
            RowNumberAndSum[1] = SumOfRow(matrix, RowNumberAndSum[0]);
        }
    }
    return RowNumberAndSum;
}

void PrintArray(int[] array) 
{
    System.Console.Write("Индекс строки с наименьшей суммой элементов: ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            System.Console.Write(", наименьшая сумма элементов: ");
        }   
    }
}


FillMatriх(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
int[] userResult = MinimumSumRow(matrix);
PrintArray(userResult);