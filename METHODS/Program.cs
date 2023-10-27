// Здесь собраны полезные функции

// Очистить консоль

Console.Clear();


// Создание массива случайных чисел

int[] GetRandomArray(int start, int end, int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

// Вывод и печать массива

//Вариант 1

void PrintArray(int[] array) 
{
  
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t"); // \t обозначает знак табуляции 
    }    
}

//Вариант 2

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


// Функция вывода сообщения и приема данных от пользователя

int TakeNumber(string message)  
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
