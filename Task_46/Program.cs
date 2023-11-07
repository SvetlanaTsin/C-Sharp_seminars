/*
46. Задайте двумерный массив размером m×n, заполненный 
случайными целыми числами.
*/
Console.Clear();

int TakeNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int userStart = TakeNumber("Введите начало диапазопа: ");
int userEnd = TakeNumber("Введите конец диапазопа: ");
int userRows = TakeNumber("Введите количество строк: ");
int userColumns = TakeNumber("Введите количество столбцов: ");

int[,] FillMatriх(int start, int end, int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(start, end);
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($" {matrix[i, j]}  ");
        }
        System.Console.WriteLine();
    }
}

int[,] userMatrix = FillMatriх(userStart, userEnd, userRows, userColumns);
PrintArray(userMatrix);