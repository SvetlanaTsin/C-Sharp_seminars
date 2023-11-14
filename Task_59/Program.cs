/*
59. Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент 1, на выходе получим следующий массив:
9 2 3
2 2 4
2 6 7
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
            System.Console.Write($"{matrix[i, j]}, \t");
        }
        System.Console.WriteLine();
    }
}

int[] FindMinIndex(int[,] matrix)
{
    int[] minIndex = { 0, 0 };
    int min = matrix [0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i, j] < min)
            {
                min = matrix[i, j];
                minIndex[0] = i;
                minIndex[1] = j;
            }    
        }
    }
    return minIndex;
}

void PrintArray(int[] array) 
{
    System.Console.Write("Индексы наименьшего элемента: [");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            System.Console.Write(", ");
        }   
    }
    System.Console.WriteLine("]");
}

// int[,] CreateNewMatrix(int[,] matrix, int row, int column)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {   
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
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

int[] userMinIndex = FindMinIndex(matrix);
PrintArray(userMinIndex);
System.Console.WriteLine();

int userRow = userMinIndex[0];
int userColumn = userMinIndex[1]; 
int[,] userNewMatrix = CreateNewMatrix(matrix, userRow, userColumn);
PrintMatrix(userNewMatrix);
