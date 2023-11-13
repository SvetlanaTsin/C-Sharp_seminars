/*
55. Задайте двумерный массив. Напишите программу,
 которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести 
сообщение для пользователя.
*/

Console.Clear();

int[,] matrix = new int[3, 4];

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

int[,] ReplaceRowsColumns(int[,] matrix)
{
    int
}

//сделать copy array, чтобы сохранить исх массив

