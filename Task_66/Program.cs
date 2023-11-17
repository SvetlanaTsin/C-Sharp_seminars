/*
66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Clear();

int TakeNumber(string message)  
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int SumInterval(int n1, int n2)
{   
    if (n2 >= n1) return n2 + SumInterval(n1, n2 - 1);
    else return 0;   
}

int userNumber1 = TakeNumber("Введите первое число: ");
int userNumber2 = TakeNumber("Введите второе число: ");
System.Console.WriteLine();
int userResult = SumInterval(userNumber1, userNumber2);
System.Console.WriteLine(userResult);