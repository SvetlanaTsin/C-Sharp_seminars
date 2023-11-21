/*
60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/
Console.Clear();

int [,,] array3D = new int [3, 2, 2];

void Fill3DArray(int[,,] matrix)
{
    // int y = 0; 

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(10, 99); 
                // y = matrix[i, j, k];                           пыталась сделать неповторяющиеся числа, но не получается

                // for (int l = i; l < matrix.GetLength(0); l++)
                // {
                //     while (matrix[l, j, k] == y)
                //     {
                //         matrix[i, j, k] = new Random().Next(10, 99);
                //     }
                // }
            }
        }
    }
}


void Print3DArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                 System.Console.Write($"[{i},{j},{k}] {matrix[i, j, k]}\t");
            }

        }
        System.Console.WriteLine();
    }
}

Fill3DArray(array3D);
Print3DArray(array3D);