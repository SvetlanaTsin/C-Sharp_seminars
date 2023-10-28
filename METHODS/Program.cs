// Здесь собраны полезные функции

// ОЧИСТИТЬ КОНСОЛЬ

Console.Clear();


// СОЗДАНИЕ МАССИВА СЛУЧАЙНЫХ ЧИСЕЛ

int[] GetRandomArray(int start, int end, int length) // варианты: int[] GetRandomArray(int length), int[] GetRandomArray(int size)
{
    int[] array = new int[length]; // длину массива можно указать здесь, в момент создания массива
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end); //можно задать интервал, откуда будут браться числа
    }
    return array;
}

// ВЫВОД И ПЕЧАТЬ МАССИВА

//Вариант 1: печать со знаком табуляции между элементами

void PrintArray(int[] array) 
{
  
    for (int i = 0; i < array.Length; i++)
      {
        Console.Write(array[i]);
        if (i < array.Length - 1) // Проверяем, не последний ли элемент
        {
        Console.Write("\t"); // Добавляем табуляцию после всех элементов, кроме последнего
        }
      }
        Console.WriteLine();
}

//Вариант 2: печать в квадратных скобках с запятой между элементами

void PrintArray(int[] array) 
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            System.Console.Write(", ");
        }   
    }
    System.Console.WriteLine("]");
}


// ФУНКЦИЯ ВЫВОДА СООБЩЕНИЯ ПОЛЬЗОВАТЕЛЮ И ПРИЕМА ДАННЫХ ОТ ПОЛЬЗОВАТЕЛЯ

int TakeNumber(string message)  
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

// ПЕЧАТЬ ДВУМЕРНОГО МАССИВА

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) определяет количество строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) определяет количество столбцов
        {
            System.Console.WriteLine($"{matrix[i, j]} "); //так мы выводим одну строку с пробелами между элементами
        }
        System.Console.WriteLine(); //так мы переходим на след строку после пробегания всех столбцов
    }
}

// по умолчанию массив заполняется 0


// СОЗДАНИЕ ДВУМЕРНОГО МАССИВА И ЗАПОЛНЕНИЕ СЛУЧАЙНЫМИ ЧИСЛАМИ

int[,] = new int[i, j]; //так создается новый двумерный массив

// void FillMatriх(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = new Random().Next(start,end)
        }
        System.Console.WriteLine(); 
    }
}

