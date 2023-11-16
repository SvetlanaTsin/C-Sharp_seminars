/*
65. Задайте значения M и N. Напишите программу, которая выведет
 все натуральные числа в промежутке от M до N.
 */

Console.Clear();

System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

void Numbers(int first, int last)
{
    if (last < first ) System.Console.WriteLine("Второе число должно быть больше первого");
    if (last >= first) 
    {
        System.Console.Write(first + " ");
        Numbers(first + 1, last);
    }
     
    
}
System.Console.WriteLine();
Numbers(number1, number2);