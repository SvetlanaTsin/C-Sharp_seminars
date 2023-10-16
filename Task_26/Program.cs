/*
26. Напишите программу, которая принимает на вход число и выдаёт 
количество цифр в числе. */

System.Console.WriteLine("Enter the number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int Num(int a)
{
    int count = 0;
    for (int i = a; i > 0; i / 10)
    {
        count = count + 1;
    }
    return count;
}
int userResult = Num(userNumber);
System.Console.WriteLine(userResult);