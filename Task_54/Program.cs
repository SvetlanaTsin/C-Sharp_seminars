/*
54. Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/
Console.Clear();

int[,] matrix = new int[3, 3];

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

void SortRowsDescending(int[,] matrix)
{   
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int k = 0;
            int max = j;
            for (k = j; k < matrix.GetLength(1); k++)
            {
               if (matrix[i, max] < matrix[i, k])
               {
                    max = k;
               } 
            }
            int temp = matrix[i, max];
            matrix[i, max] = matrix[i, j];
            matrix[i, j] = temp;
        }
    }         
}



FillMatriх(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
SortRowsDescending(matrix);
PrintMatrix(matrix);