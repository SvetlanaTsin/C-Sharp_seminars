/*
Напишите программу, которая принимает на вход число
 и проверяет, кратно ли оно одновременно 7 и 23.
*/
Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int div1 = number % 7;
int div2 = number % 23;

if (div1 == 0 && div2 ==0)
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("No");
}