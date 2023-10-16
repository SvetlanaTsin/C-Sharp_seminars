/*
12. Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому.
Если второе число некратно первому, то программа выводит остаток от деления.
*/
Console.Clear();
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = number2 % number1;

if (result == 0)
{
    System.Console.WriteLine("Yes");
}
if (result != 0)
{
    System.Console.WriteLine(result);
}



