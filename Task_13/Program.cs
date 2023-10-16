/*
13. Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
*/

// ПЕРВОЕ РЕШЕНИЕ:
Console.Clear();
System.Console.WriteLine("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
int dig3 = 0;

if (number > 99 && number < 1000)
{
    dig3 = number % 10;
    System.Console.WriteLine(dig3);
}

if (number >= 1000)
{
    int count = number; // вводим переменную count, чтобы начать работать с числом в цикле
    while (count >= 1000)
    {
       count = count / 10;
    }
    dig3 = count % 10;
    System.Console.WriteLine(dig3);
}
else System.Console.WriteLine("There is no 3rd digit");


//ВТОРОЕ РЕШЕНИЕ (С ФУНКЦИЕЙ):
// Console.Clear();
// System.Console.WriteLine("Enter the number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 99) System.Console.WriteLine(number.ToString()[2]);

// else System.Console.WriteLine("There is no 3rd digit");
