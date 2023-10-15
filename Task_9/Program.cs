/*
Напишите программу, которая выводит случайное число из отрезка [10, 99]
и показывает наибольшую цифру числа.
*/
Console.Clear();
int number = new Random().Next(9, 100);
System.Console.WriteLine(number);

int dig1 = number / 10;
int dig2 = number % 10;
int digmax = dig1;

if (dig1 != dig2)
{
  if (dig2 > dig1) digmax = dig2;
  System.Console.WriteLine(digmax);
}
else
{
   System.Console.WriteLine("Цифры одинаковые"); 
}