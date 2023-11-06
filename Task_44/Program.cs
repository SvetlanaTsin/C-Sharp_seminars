/*
44. Не используя рекурсию выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0, 1.
N = 5 -> 0 1 1 2 3
N = 3 -> 0 1 1 
N = 7 -> 0 1 1 2 3 5 8
*/
Console.Clear();
System.Console.WriteLine("Введите количество чисел Фибоначчи: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int[] Fibonacci(int length)
{
        int[] array = new int[length];
        array[0] = 0;
        array[1] = 1;
        for (int i = 2; i < array.Length; i++)
        {
            array[i] = array[i - 1] + array[i - 2];
        }
      return array;
}

void PrintArray(int[] array) 
{
      for (int i = 0; i < array.Length; i++)
      {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
        Console.Write(" "); 
        }
      }
}

int[] userArray = Fibonacci(userNumber);
System.Console.Write($"Если N = {userNumber} -> ");
PrintArray(userArray);