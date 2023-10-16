/*
13. Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
*/
Console.Clear();
System.Console.WriteLine("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99) System.Console.WriteLine(number.ToString()[2]);

else System.Console.WriteLine("There is no 3rd digit");
