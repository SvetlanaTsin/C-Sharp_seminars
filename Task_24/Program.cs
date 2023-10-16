/* 24. Напишите программу, которая принимает на вход число (А) и 
выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */


// РЕШЕНИЕ ПЕРВОЕ (БЕЗ ФУНКЦИИ)

/*System.Console.WriteLine("Enter the number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= numberA; i++)
{
    sum = sum + i;
}
System.Console.WriteLine(sum);*/ 


//ВТОРОЕ РЕШЕНИЕ (С ФУНКЦИЕЙ):

System.Console.WriteLine("Enter the number A: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int Num(int a)
{
    int sum = 0;
    for (int i = 0; i <= a; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int userResult = Num(userNumber);
System.Console.WriteLine(userResult);
