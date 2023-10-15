/*
10. Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 999)
{
    int dig2 = number / 10 % 10;
    System.Console.WriteLine(dig2);
}
else
{
    System.Console.WriteLine("Ошибка ввода");
}
