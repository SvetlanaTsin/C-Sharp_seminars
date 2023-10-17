/*
27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
*/
Console.Clear();
System.Console.WriteLine("Enter the number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int Num(int a)
{
    int sum = 0;
    int dig = 0;

    if (a < 0) a = a * -1;

    for (int i = a; i > 0; i /= 10)
    {
        dig = i % 10;
        sum = sum + dig;
    }
    return sum;
}
int userResult = Num(userNumber);
System.Console.WriteLine(userResult);