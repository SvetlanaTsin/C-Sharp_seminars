/* 
3. Напишите программу, которая будет выдавать название дня недели
 по заданному номеру.
*/
System.Console.WriteLine("Введите номер дня недели: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber == 1)
{ 
    System.Console.WriteLine("Понедельник");
}

else if (userNumber == 2)
{
    System.Console.WriteLine("Вторник");
}

else if (userNumber == 3)
{
    System.Console.WriteLine("Среда");
}

else if (userNumber == 4)
{
    System.Console.WriteLine("Четверг");
}

else if (userNumber == 5)
{
    System.Console.WriteLine("Пятница");
}

else if (userNumber == 6)
{
    System.Console.WriteLine("Суббота");
}

else if (userNumber == 7)
{
    System.Console.WriteLine("Воскресенье");
}
else
{
    System.Console.WriteLine("Нет такого дня недели");
}