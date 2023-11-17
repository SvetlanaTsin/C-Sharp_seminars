/* 
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Функция Аккермана: 
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
 Console.Clear();

int TakeNumber(string message)  
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Akkerman( int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    else return 0;
}

int userNumber1 = TakeNumber("Введите первое число: ");
int userNumber2 = TakeNumber("Введите второе число: ");
System.Console.WriteLine();
int userResult = Akkerman(userNumber1, userNumber2);
System.Console.WriteLine(userResult);