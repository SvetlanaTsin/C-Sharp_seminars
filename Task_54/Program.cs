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

int[,] SortRowsDescending(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
        
            if (matrix[i, j] < matrix[i, j +1])
            {
                int temp = matrix[i, j];
                newMatrix[i, j] = matrix[i, j + 1];
                newMatrix[i, j + 1] = temp;
            }
            else
            {
                newMatrix[i, j] = matrix[i, j];
            }
        }
    }
    return newMatrix;
}



FillMatriх(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
int[,] newUserMatrix = SortRowsDescending(matrix);
PrintMatrix(newUserMatrix);