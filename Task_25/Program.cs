/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

// ПЕРВОЕ РЕШЕНИЕ (ЧЕРЕЗ ФУНКЦИЮ):
Console.Clear();
System.Console.WriteLine("Enter the number A: ");
int userA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the number B: ");
int userB = Convert.ToInt32(Console.ReadLine());

double result = Math.Pow(userA, userB);

System.Console.WriteLine($"{userA}, {userB} -> {result}");

//ВТОРОЕ РЕШЕНИЕ (ЧЕРЕЗ ЦИКЛ):
// Console.Clear();
// System.Console.WriteLine("Enter the number A: ");
// int userA = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Enter the number B: ");
// int userB = Convert.ToInt32(Console.ReadLine());

// int result = userA;
// int count = userB;

// for (int i = count; i >= 2; i = i - 1)
// {
//     result = result * userA; 
// }
// System.Console.WriteLine($"{userA}, {userB} -> {result}");
