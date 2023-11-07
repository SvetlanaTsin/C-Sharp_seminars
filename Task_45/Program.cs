/*
45. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/

Console.Clear();

System.Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] userArray = new int[size];

for (int i = 0; i < userArray.Length; i++)
{
    System.Console.WriteLine("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    userArray[i] = n;
}

int[] CopyArray(int[] array)
{
    int[] arrCopy = new int[array.Length];
    for (int i = 0; i < arrCopy.Length; i++)
    {
        arrCopy[i] = array[i];
    }
    return arrCopy;
}

void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write("\t");
        }
    }
    Console.WriteLine();
}

PrintArray(userArray);
int[] userCopy = CopyArray(userArray);
PrintArray(userCopy);