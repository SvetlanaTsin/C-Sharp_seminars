/*
53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку
массива.
*/
Console.Clear();

int[,] matrix = new int[4, 4];

void FillMatriх(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = new Random().Next(1,10);
        }    
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            System.Console.Write($"{matrix[i, j]} \t"); 
        }
        System.Console.WriteLine(); 
    }
}

void SwapRows(int[,] matrix)
{
    int rows = matrix.GetLength(0) - 1;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[0, j];
        matrix [0, j] = matrix[rows, j];
        matrix [rows, j] = temp; 
    }
}


FillMatriх(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
SwapRows(matrix);
PrintMatrix(matrix);