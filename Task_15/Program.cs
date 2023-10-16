/*
Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.
*/
Console.Clear();
System.Console.WriteLine("Введите номер дня недели: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber > 0 && userNumber < 8)
{
    if (userNumber == 6 || userNumber == 7)
    {
        System.Console.WriteLine("Yes");
    }
    else
    {
        System.Console.WriteLine("No");
    }

}
else
{
    System.Console.WriteLine("Input error");
}
