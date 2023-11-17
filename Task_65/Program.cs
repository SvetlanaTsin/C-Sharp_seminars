/*
65. Задайте значения M и N. Напишите программу, которая выведет
 все натуральные числа в промежутке от M до N.
 */

Console.Clear();

// System.Console.WriteLine("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

int number1 = 7;
int number2 = 11;

void Numbers(int first, int last)
{
    if (last >= first) 
    {
        System.Console.Write(first + " ");
        Numbers(first + 1, last);
    } 
}
Numbers(number1, number2);