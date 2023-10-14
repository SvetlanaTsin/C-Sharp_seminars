/*
4. Напишите программа которая принимает на вход три числа
и выдаёт максимальное из этих чисел.
*/

Console.Clear();
System.Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

int result = a;
if (b > result)
{
    result = b;
}
if (c > result)
{
    result = c;
}

System.Console.WriteLine(result);
