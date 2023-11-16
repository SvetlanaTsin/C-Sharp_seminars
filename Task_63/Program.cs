/*
63. Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N.
*/

// ВАРИАНТ 1, БЕЗ РЕКУРСИИ
// Console.Clear();

// int numberN = 5;

// void Numbers(int n)
// {
//     int current = 0;
//     while (current < n) 
//     {
//         current++;
//         System.Console.WriteLine(current);
//     } 
// }
// Numbers(numberN);

//ВАРИАНТ 2, ЧЕРЕЗ РЕКУРСИЮ

Console.Clear();

int numberN = 0;

void Numbers(int n, int current = 1)
{
    //if (n == 0) System.Console.WriteLine("Необходимо число больше 0");
    if (n >= current) 
    {
        System.Console.Write(current + " ");
        Numbers(n, current + 1);
    } 
}
Numbers(numberN);