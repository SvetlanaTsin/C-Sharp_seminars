/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
 y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
*/
Console.Clear();
System.Console.WriteLine("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

void LineIntersection (double a1, double c1, double a2, double c2)
{
    if (a1 == a2) 
    {
        System.Console.WriteLine("Прямые параллельны, нет точек пересечения");
    }
    else if (a1 == a2 && c1 == c2)
    {
        System.Console.WriteLine("Прямые совпадают");
    }
    else 
    {
        double x = Math.Round((c2 - c1) / (a1 - a2), 2);
        double y = Math.Round((a2 * x + c2), 2);
        System.Console.WriteLine($"Прямые пересекаются в точке с координатами X: {x} и Y: {y}");
    }
}

LineIntersection (k1, b1, k2, b2);