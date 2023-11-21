/*
58 Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
*/

Console.Clear();
int[,] matrixA = new int[2, 3];
int[,] matrixB = new int[3, 2];

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
            System.Console.Write(matrix[i, j]);
            if (j < matrix.GetLength(1) - 1)
            {
                System.Console.Write("\t");
            }
        }
        System.Console.WriteLine();
    }
}

void MultiplyIfPossible(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        System.Console.WriteLine("Эта операция невозможна");
    }
    else 
    {
        int [,] muliplicative = MatrixMultiplication(matrix1, matrix2);
        PrintMatrix(muliplicative);
    }
}

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int [,] muliplicative = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < muliplicative.GetLength(0); i++)
    {
        for (int j = 0; j < muliplicative.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                muliplicative[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return muliplicative;
}

FillMatrix(matrixA);
PrintMatrix(matrixA);
System.Console.WriteLine();
FillMatrix(matrixB);
PrintMatrix(matrixB);
System.Console.WriteLine();
MultiplyIfPossible(matrixA, matrixB);