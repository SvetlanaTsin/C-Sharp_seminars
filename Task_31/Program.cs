/*
31. Задайте массив из 12 элементов, заполненный случайными числами из интервала от -9 до 9. 
Найдите сумму отриц и полож чисел в массиве.
*/
Console.Clear();

int[] GetRandomArray(int start, int end, int length) // функция для получения случайного массива
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

void PrintArray(int[] array) // ф-ция для вывода массива
{
    System.Console.Write("["); //чтобы вывод был красивый, начинаем печать с [
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

int TakeEntNumber(string message)  //? ф-ция для вывода сообщения и приема чисел от пользователя
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumPositiveNum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum = sum + array[i]; // другая запись: sum +=array[i]
    }
    return sum;
}

int SumNegativeNum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sum = sum + array[i]; // другая запись: sum +=array[i]
    }
    return sum;
}

int userArraySize = TakeEntNumber("Please enter array size: ");
int userArrayStart = TakeEntNumber("Please enter array start number range: ");
int userArrayEnd = TakeEntNumber("Please enter array end number range: ");

int[] userArray = GetRandomArray(userArrayStart, userArrayEnd, userArraySize);
PrintArray(userArray);

int posArraySum = SumPositiveNum(userArray);
int negArraySum = SumNegativeNum(userArray);

System.Console.WriteLine();
System.Console.WriteLine($"Sum of positive numbers is {posArraySum}");
System.Console.WriteLine($"Sum of negative numbers is {negArraySum}");