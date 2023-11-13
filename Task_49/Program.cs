/*
49. Задайте двумерный массив. Найдите элементы, 
у которых оба индексы чётные, и замените эти элементы на их квадраты.
*/
Console.Clear();

int[,] matrix = new int[3, 4];

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
            System.Console.Write($" {matrix[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}

void SquareElementEvenIndex(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2) 
        {
            matrix[i, j] = matrix[i, j] * matrix[i, j];
        }    
    }
}

FillMatriх(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
SquareElementEvenIndex(matrix);
PrintMatrix(matrix);