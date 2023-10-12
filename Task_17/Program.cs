/* 
17. Напишите программу, которая принимает на вход координаты точки (X и Y),
 причём X ≠ 0 и Y ≠ 0,
и выдаёт номер четверти плоскости, в которой находится эта точка.
x=34; y=-30 -> 4 
x=2; y=4-> 1
x=-34; y=-30 -> 3
*/

Console.Clear();

Console.Write("Введите координаты точки X: ");
int userX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки Y: ");
int userY = Convert.ToInt32(Console.ReadLine());

if (userX > 0 && userY > 0)
{
    System.Console.WriteLine("1");
}

if (userX < 0 && userY > 0)
{
    System.Console.WriteLine("2");
}

if (userX < 0 && userY < 0)
{
    System.Console.WriteLine("3");
}

if (userX > 0 && userY < 0)
{
    System.Console.WriteLine("4");
}

if (userX == 0 && userY != 0)
{
    System.Console.WriteLine("Точка на оси Х");
}

if (userX != 0 && userY == 0)
{
    System.Console.WriteLine("Точка на оси Y");
}

if (userX == 0 && userY == 0)
{
    System.Console.WriteLine("Точка на пересечении осей X и Y");
}