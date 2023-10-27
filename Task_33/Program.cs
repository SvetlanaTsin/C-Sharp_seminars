/* 
33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
*/
Console.Clear();

int TakeNumber(string message)  
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GetRandomArray(int start, int end, int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

void PrintArray(int[] array) 
{
    System.Console.Write("[");
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

bool FindNum(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true; // для функции типа bool не нужно делать переменную result, просто просим вернуть true если выполняется условие
    }
    return false; // False задаем по умолчанию (во всех случаях, когда не выполняется условие)
}

int userArraySize = TakeNumber("Enter array size: ");
int userArrayStart = TakeNumber("Enter array start number range: ");
int userArrayEnd = TakeNumber("Enter array end number range: ");

int[] userArray = GetRandomArray(userArrayStart, userArrayEnd, userArraySize);
PrintArray(userArray);

int userNumber = TakeNumber("Enter the number: ");
System.Console.WriteLine(FindNum(userArray, userNumber));



