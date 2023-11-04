/*
40. Напишите программу,которая принимает три числа и определяет, 
может ли существовать треугольник с сторонами такой длины 
(т.е. сумма любых двух сторон д.б. больше третьей стороны)
*/

Console.Clear();

System.Console.WriteLine("Введите число A: ");
int userA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int userB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
int userC = Convert.ToInt32(Console.ReadLine());

bool Triangle(int a, int b, int c)
{
    bool result = false; //заводим переменную result и по умолчанию делаем = false, будем проверять на истинность
    if (a + b > c && a + c > b && b + c > a) result = true;
    return result;
}

System.Console.WriteLine(Triangle(userA, userB, userC));




