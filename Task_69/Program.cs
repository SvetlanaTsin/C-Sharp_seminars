/*
69. Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
*/
Console.Clear();

System.Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите степень числа: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Pow(int n1, int n2)
{
   if (n2 == 1) return 1;
   else return n1 * Pow(n1, n2 - 1);
}

int result = Pow(number1, number2);
System.Console.WriteLine(result);