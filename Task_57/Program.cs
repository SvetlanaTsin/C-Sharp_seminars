/*
57. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
 сколько раз встречается элемент входных данных.
1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раза
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
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

найти макс значение массива

void PrintCount (int[,] matrix, int max)
{
    for (int k = 0; k <= max; k++)
    {
        
    int count = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (k == matrix[i, j]) 
            { System.Console.WriteLine($"Число {k} встречается {count} раз");
        }
    }
}
}
