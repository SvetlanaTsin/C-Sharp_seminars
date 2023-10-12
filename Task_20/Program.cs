/* 
20. Напишите программу, которая принимает на вход координаты двух точек и находит
расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

Console.WriteLine("Введите координаты точки A (x, y): ");
int userAx = Convert.ToInt32(Console.ReadLine());
int userAy = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B (x, y): ");
int userBx = Convert.ToInt32(Console.ReadLine());
int userBy = Convert.ToInt32(Console.ReadLine());

// гуглим формулу нахождения расстояния, переводим ее на с# следующим образом:

// int squarex = (userBx - userAx) * (userBx - userAx);

double squarex = Math.Pow(userBx - userAx, 2); 
/* Math.Pow(а, 3) - функция возведения в степень, где а -что возводим в степень,
 3 - в какую степень (нашли на Киберфоруме) */

double squarey = Math.Pow(userBy - userAy, 2);

double rootxy = Math.Sqrt(squarex + squarey);

System.Console.WriteLine(Math.Round(rootxy, 2)); 
/* Math.Round (а,2) - функция округления чисел, а-какое число округляем,
 2 - сколько знаков после запятой */
