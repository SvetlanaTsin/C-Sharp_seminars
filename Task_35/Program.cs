/* 
35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
 значения которых лежат в отрезке [10,99]. 
*/
Console.Clear();

int TakeNumber(string message)  
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GetRandomArray() //если нужно указать конретный размер массива, в функцию ничего не ставим
{
    int[] array = new int[123]; //указываем размер массива в тот момент, когда мы его создаем с помощью new int[]
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
    return array;
}

void PrintArray(int[] array) 
{
  
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }    
}

int CountNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99) 
        {
            count++;
        }
    }
    return count;
}

int[] userArray = GetRandomArray();
PrintArray(userArray);
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine(CountNum(userArray));