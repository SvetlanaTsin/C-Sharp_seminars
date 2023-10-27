/*
37. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.
*/
Console.Clear();

int[] GetRandomArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

int[] ProdArray(int[] oldArr)                 // создаем функцию, которая принимает массив и выдает массив
{
    int[] newArr = new int[oldArr.Length / 2]; //создаем новый массив, длина которого будет равно половине изначального массива
    int product = 0;                         // создаем переменную, куда складываем произведения элементов массива
    for (int i = 0; i < oldArr.Length / 2; i++)
    {
        product = oldArr[i] * oldArr[oldArr.Length - 1 - i];    // умножаем первый элемент на последний, с индексом, где указана (длина какого массива -1 -i) Напр., длина массива 5, а посл индекс 4; на втором круг надо взять предпоследнее число, поэтому еще каждый раз отнимаем i
        newArr[i] = product;         //нужно записать каждое произведение как элемент нового массива
    }
    return newArr;
}

int[] userArray = GetRandomArray(7); //когда у нас нигде не указана длина массива, мы должные ее указать при вызывании функции
PrintArray(userArray);
System.Console.WriteLine();

int[] newUserArray = ProdArray(userArray);
PrintArray(newUserArray);