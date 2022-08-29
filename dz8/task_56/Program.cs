/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
Console.Clear();
Console.WriteLine("#Task-56");

// инициализация массива и заполнение случайными числами
int[,] GetArray(int m, int n) {
    int[,] array = new int[m, n];
    for(int i=0; i < m; i++) {
        for(int j=0; j < n; j++) {
            array[i, j] = new Random().Next(1, 20) / 2;
        }
    }
    return array;
}

// вывод значений массива
void PrintArray(int[,] array) {
    for(int i=0; i < array.GetLength(0); i++) {
        for(int j=0; j < array.GetLength(1); j++) {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}

void GetIndexMinSumRowArray(int[,] array) {
    int indexRow = -1;
    int minRow = Int32.MaxValue;
    for(int i = 0; i < array.GetLength(0); i++) {
        int sumRow = 0;
        for(int j = 0; j < array.GetLength(1); j++) {
            sumRow += array[i,j];
        }
        if(minRow > sumRow) {
            minRow = sumRow;
            indexRow = i;
        }
        Console.WriteLine($"Row[{i}] = {sumRow}");
    }
    Console.WriteLine("---------");
    Console.WriteLine($"Индекс строки с минимальной суммой элементов = {indexRow}");
}

// создаем массив
int[,] array = GetArray(4, 4);

// выводим исходный массив
PrintArray(array);
Console.WriteLine("---------");

// Индекс строки с минимальной суммой
GetIndexMinSumRowArray(array);