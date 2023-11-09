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

// СОЗДАНИЕ МАССИВА СЛУЧАЙНЫХ ВЕЩЕСТВЕННЫХ ЧИСЕЛ (С ОКРУГЛЕНИЕМ ДО СОТЫХ)

double[] GetRandomArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((new Random().Next(0, 10) + new Random().NextDouble()), 2); // складываем случайное целое число и случайную дробную часть, округляем до сотых
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) определяет количество строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) определяет количество столбцов
        {
            System.Console.Write($"{matrix[i, j]} \t"); //так мы выводим одну строку с табуляцией между элементами (так ровнее)
        }
        System.Console.WriteLine(); //так мы переходим на след строку после пробегания первой строки
    }
}

// по умолчанию массив заполняется 0


// СОЗДАНИЕ ДВУМЕРНОГО МАССИВА И ЗАПОЛНЕНИЕ СЛУЧАЙНЫМИ ЧИСЛАМИ

int[,] matrix = new int[i, j]; //так создается новый двумерный массив

void FillMatriх(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = new Random().Next(start,end);
        }    
    }
}

// МЕТОД ВЫЧИСЛЕНИЯ ФАКТОРИАЛА ЧЕРЕЗ РЕКУРСИЮ

int Factorial(int n)
{
    // 1!=1, 0!=1
    if (n == 1) return 1;
    else return n * Factorial(n - 1); 
}
for (int i = 1; i < n; i++)
{
    System.Console.WriteLine($"{i}! = {Factorial[i]}");
}


// ЧИСЛА ФИБОНАЧЧИ 

// Вариант 1: через рекурсию
// (медленный метод, если надо выводить более 40 чисел)

double Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < n; i++)
{
    System.Console.WriteLine(Fibonacci(i));
}

//Вариант 2: через цикл

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


// НАХОЖДЕНИЕ СРЕДНЕГО АРИФМЕТИЧЕСКОГО ПО СТОЛБЦАМ МАТРИЦЫ

double[] AverageInColumns(int[,] matrix)  // в качестве результата метод выдает одномерный массив (ряд чисел), ср. арифм. - резутат деления, пожтому все величины double
{
    double[] average = new double[matrix.GetLength(1)]; // создаем массив, куда будет складывать ответы
       
    for (int j = 0; j < matrix.GetLength(1); j++) // задаем движение по столбцам (сначала проходится 1 столбец до конца, потом 2 и т.д.)
    {
        double sum = 0;                           // сюда будем складывать сумму элементов столбца
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
           sum += matrix [i, j];
        }
        average [j] = Math.Round(sum / matrix.GetLength(0), 1);  // после прохождения столбца до конца находим среднее по столбцу (это j-й элемент нашего массива-ответа)
    }
    return average;
}


//НАХОЖДЕНИЕ СРЕДНЕГО АРИФМЕТИЧЕСКОГО ПО СТРОКАМ МАТРИЦЫ

double[] AverageInRows(int[,] matrix)  
{
    double[] average = new double[matrix.GetLength(0)]; 
       
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        double sum = 0;                          
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           sum += matrix [i, j];
        }
        average [i] = Math.Round(sum / matrix.GetLength(1), 1); 
    }
    return average;
}
