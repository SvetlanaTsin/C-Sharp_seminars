/* 
5. Напишите программу, которая на вход принимает одно число (N), 
а на выходе показывает все целые числа в промежутке от -N до N. 
*/

Console.WriteLine("Введите число: ");

int userNumber = Convert.ToInt32(Console.ReadLine());

int start = userNumber * -1;

while (start <= userNumber)
{
    System.Console.WriteLine("start");
    start = start + 1;
}
