/*
52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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

//double AverageColumn(int[,] matrix, int columnN)
{
    double result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int j = columnN;
        while (j < matrix.GetLength(1))
        {
            result = (result + matrix[i, j]) / matrix.GetLength(0);
        }
    }
    return result;
}

int[,] matrix = new int[3, 4];
FillMatrix(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();

double userAvCol1 = AverageColumn(matrix, 0);
double userAvCol2 = AverageColumn(matrix, 1);
double userAvCol3 = AverageColumn(matrix, 2);
double userAvCol4 = AverageColumn(matrix, 3);

System.Console.WriteLine($"Среднее арифметическое каждого столбца: {userAvCol1}, {userAvCol2}, {userAvCol3}, {userAvCol4}");