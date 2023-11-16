/*
67. Напишите программу, 
которая будет принимать на вход число и возвращать сумму его цифр.
*/

Console.Clear();

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Numbers(int n)
{
    if (n % 10 > 0) return n % 10 + Numbers(n / 10);  
    else return 0;
}

int userNumber = Numbers(number);
System.Console.WriteLine(userNumber);