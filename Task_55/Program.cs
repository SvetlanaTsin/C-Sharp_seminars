/*
55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести 
сообщение для пользователя.
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

void SwapRowsAndColumns(int[,] matrix)
{
   int rows = matrix.GetLength(0);
   int columns = matrix.GetLength(1);

   if (rows != columns) System.Console.WriteLine($"Невозможно выполнить эту операцию");

   int[,] newMatrix = new int[rows, columns];

   for (int i = 0; i < rows; i++)
   {
      for (int j = 0; j < i; j++) // почему j<i?
      {
         int temp = matrix[i, j];
         matrix [i, j] = matrix[j, i];
         matrix [j, i] = temp; 
      }
   }
}

FillMatriх(matrix);
PrintMatrix(matrix);
System.Console.WriteLine();
SwapRowsAndColumns(matrix);
PrintMatrix(matrix);