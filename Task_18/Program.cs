/*
18. Напишите программу, которая по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).
*/

Console.WriteLine("Введите номер четверти: ");
int userQ = Convert.ToInt32(Console.ReadLine());

if (userQ == 1)
{
   System.Console.WriteLine("x>0, y>0");
}

else if (userQ == 2)
{
   System.Console.WriteLine("x<0, y>0");
}

else if (userQ == 3)
{
   System.Console.WriteLine("x<0, y<0");
}

else if (userQ == 4)
{
   System.Console.WriteLine("x>0, y<0");
}

else if (userQ != 1 || userQ != 2 || userQ != 3 || userQ != 4)
{
   System.Console.WriteLine("Неправильно введен номер четверти");
}