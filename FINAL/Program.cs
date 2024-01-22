
/* 
Задача: Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]  
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] arr = {"1234", "hey", "-2444", "cofee", ":)"};

int NumberOfElements(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count += 1;
        }
    }
    return count;
}

string[] NewArray(string[] array) 
{
    string[] result = new string[NumberOfElements(arr)];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

void PrintArray(string[] array) 
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"\u0022{array[i]}\u0022");
        if (i < array.Length - 1)
        {
            System.Console.Write(", ");
        }   
    }
    System.Console.WriteLine("]");
}

string[] userArray = NewArray(arr);
PrintArray(userArray);



//ВТОРОЕ РЕШЕНИЕ (через печать массива)

// string[] arr = {":)", "hey", "1234", "-2444", "cofee"};

// int NumberOfElements(string[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i].Length <= 3)
//         {
//             count += 1;
//         }
//     }
//     return count;
// }

// void PrintNewArray(string[] array) 
// {
//     int number = NumberOfElements(arr);
//     int count = 0;

//     System.Console.Write("[");

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i].Length <= 3)
//         {
//             System.Console.Write($"\u0022{array[i]}\u0022");
//             count += 1;

//             if (count < number)
//             {
//                 System.Console.Write(", ");
//             }   
//         } 
//     }
//     System.Console.WriteLine("]");           
// }
       
// PrintNewArray(arr);