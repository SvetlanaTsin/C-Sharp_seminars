/*
30. Напишите программу, которая выводит массив из 8 элементов,
 заполненный нулями и единицами в случайном порядке.
*/

Console.Clear();

int[] GetRandArray()  // int[] - это тип массива
{
    int[] array = new int [size];  // создаем пустой массив c с пом команды new int, в [] указываем размер
    
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2); // array[i] это значит каждый элемент массива; new Random.. это команда вызывает новое случ число. Все вместе значит: вместо каждого элемента массива кладем случ число 0,1,2      
    }
    return array;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]}, ");
    }
}
int [] u

