/* Напишите программу которая на вход принимает число number 
и выводит, является ли число чётным (делится ли оно на два без остатка).
*/
Console.Clear();
Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber % 2 == 0)
{
    System.Console.WriteLine($"число `{userNumber}` четное");
}

if (userNumber % 2 == 1)
{
    System.Console.WriteLine($"число `{userNumber}` нечетное");
}