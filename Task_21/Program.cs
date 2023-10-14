/* 
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
*/
Console.Clear();
Console.WriteLine("Введите координаты точки A (x, y, z): ");
int userAx = Convert.ToInt32(Console.ReadLine());
int userAy = Convert.ToInt32(Console.ReadLine());
int userAz = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B (x, y, z): ");
int userBx = Convert.ToInt32(Console.ReadLine());
int userBy = Convert.ToInt32(Console.ReadLine());
int userBz = Convert.ToInt32(Console.ReadLine());

double squarex = Math.Pow(userBx - userAx, 2); 
double squarey = Math.Pow(userBy - userAy, 2);
double squarez = Math.Pow(userBz - userAz, 2);

double rootxyz = Math.Sqrt(squarex + squarey + squarez);

System.Console.WriteLine(Math.Round(rootxyz, 2)); 

