/* 00. Напишите программу, 
которая на вход принимает число и выдаёт его квадрат */

System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int result = userNumber * userNumber;
System.Console.WriteLine(result);