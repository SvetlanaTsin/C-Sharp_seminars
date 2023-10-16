/*
11. Напишите программу, которая выводит 
случайное трёхзначное число и удаляет вторую цифру этого числа.
*/
Console.Clear();
int number = new Random().Next(99, 1000);
System.Console.WriteLine(number);
int dig1 = number / 100;
int dig2 = number % 10;
System.Console.WriteLine($"{dig1}{dig2}");