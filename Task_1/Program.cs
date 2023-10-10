/* Напишите программу, которая принимает два числа и проверяет, 
является ли первое квадратом второго
*/

System.Console.WriteLine("Введите первое число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
int sqNumber2 = userNumber2 * userNumber2;
bool result = userNumber1 == sqNumber2;
System.Console.WriteLine(result);