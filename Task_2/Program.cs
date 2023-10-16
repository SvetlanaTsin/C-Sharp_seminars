/* 
2. Написать программу которая на вход принимает два числа
и выводит, какое число большее, а какое меньшее.
*/
Console.Clear();
System.Console.WriteLine("Введите первое число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
if (userNumber1 > userNumber2)
{
    System.Console.WriteLine($"{userNumber1} больше чем {userNumber2}");
}
if (userNumber1 < userNumber2)
{
    System.Console.WriteLine($"{userNumber1} меньше чем {userNumber2}");
}
if (userNumber1 == userNumber2)
{
    System.Console.WriteLine($"{userNumber1} равно {userNumber2}");
}