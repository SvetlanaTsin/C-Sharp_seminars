/*
51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
(с индексами (0,0); (1;1) и т.д.)
*/
Console.Clear();

int[,] matrix = new int[5, 5];

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

int MainDiagonalSum(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum = sum + matrix[i, j];
        }
    }
    return sum;
}

FillMatriх(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
int userResult = MainDiagonalSum(matrix);
System.Console.WriteLine($"Сумма элементов на главной диагонали: {userResult}");