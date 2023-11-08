/*
50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание, что такого элемента нет.
*/
Console.Clear();

int TakeNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

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

void FindElement(int[,] matrix, int rowN, int columnN)
{
    if (rowN > matrix.GetLength(0) || columnN > matrix.GetLength(1))
    {
        System.Console.WriteLine("Такого элемента в массиве нет");
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (rowN == i && columnN == j)
            {
                Console.WriteLine($"Элемент равен {matrix[i, j]}");
            }
        }
    }
}

int[,] matrix = new int[3, 4];
FillMatriх(matrix);

int userRowNumber = TakeNumber("Введите номер строки: ");
int userColumnNumber = TakeNumber("Введите номер столбца: ");
System.Console.WriteLine();

FindElement(matrix, userRowNumber, userColumnNumber);
System.Console.WriteLine();

PrintMatrix(matrix);