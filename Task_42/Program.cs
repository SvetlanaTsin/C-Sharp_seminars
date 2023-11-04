/*
42. Напишите программу, которая преобразует десятичное число в двоичное
45 - 101101
3- 11
2 - 10
*/

Console.Clear();
System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

string Binary(int number)
{
    string result = ""; // пока нулевой результат в типе string, записывается как пустая строка ""
    int temp = 0;
    for (int i = number; i > 0; i /= 2) // в самом цикле задаем начало отсчета - заданное число, шаг - деление на 2
    {
        temp = i % 2; // сюда складываем все остатки от деления
        result = temp + result; // в типе string + дает запись по порядку 2+2=22; запись temp+results дает возможность записывать остатки "в обратном порядке" - сначала записывается последний результат, затем предыдущие
    }

return result;
}

string userResult = Binary(userNumber);
System.Console.WriteLine(userResult);
