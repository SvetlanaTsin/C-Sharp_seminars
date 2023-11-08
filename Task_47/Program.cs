/* 
47. Задайте двумерный массив размером m×n, заполненный случайными 
вещественными числами.
*/

double[,] matrix = new double[3,4];

void FillMatriх(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = Math.Round((new Random().Next(-10, 10) + new Random().NextDouble()), 1);;
        }    
    }
}

void PrintMatrix(double[,] matrix)
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
FillMatriх(matrix);
PrintMatrix(matrix);