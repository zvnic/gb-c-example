/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.Clear();
Console.WriteLine("#Task-52");

// инициализация массива и заполнение случайными числами
int[,] GetArray(int m, int n) {
    int[,] array = new int[m, n];
    for(int i=0; i < m; i++) {
        for(int j=0; j < n; j++) {
            array[i, j] = new Random().Next(0, 10);
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

// вычисляем среднее значение по столбцам массива
void GetAverageValueColumnArray(int[,] array) {
    double avgCol = 0;
    for(int i=0; i < array.GetLength(0); i++) {
        Console.Write("-->");
        for(int j=0; j < array.GetLength(1); j++) {
            Console.Write($" {array[j, i]}");
            avgCol += array[j, i];
        }
        Console.WriteLine($" Среднее значение [{i}] столбца = {avgCol/array.GetLength(1)}");
        avgCol = 0;
    }
}

int[,] array = GetArray(4, 4);

PrintArray(array);

GetAverageValueColumnArray(array);