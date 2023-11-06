/*
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
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

int CountPos(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count = count + 1;
    }
    return count;
}


void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            System.Console.Write(", ");
        }   
    }
}
PrintArray(userArray);
int userResult = CountNeg(userArray);
System.Console.WriteLine($" -> {userResult}");
