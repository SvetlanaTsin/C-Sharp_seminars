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
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        if (i == row)
        {
           for (int j = 0; j < matrix.GetLength(1); j++)
           {
               rowSum += matrix [i, j];
           }  
        }                               
    }
    return rowSum;
}   

int[] MinimumSumRow(int[,] matrix)
{
    int[] = {0, 0};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
        }
    }
}



FillMatriх(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
int userRowSum = SumOfRow(matrix, 2);
System.Console.WriteLine(userRowSum);
