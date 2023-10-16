/* 8. Напишите программу которая на вход принимает число number, 
а на выходе выводит все чётные числа от 1 до number (включительно),
разделеные знаком табуляции.
*/
Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0)
    System.Console.Write($"{i}     ");
}


