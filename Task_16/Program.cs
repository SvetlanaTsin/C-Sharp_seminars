/*
16. Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
*/
Console.Clear();
System.Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
double sq1 = Math.Pow(number1, 2);
double sq2 = Math.Pow(number2, 2);

if (sq1 == number2 || sq2 == number1)
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("No");
}