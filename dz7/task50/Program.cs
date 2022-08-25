/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
Console.Clear();
Console.WriteLine("#Task-50");

// инициализация массива и заполнение случайными числами
int[,] GetArray(int m, int n) {
    int[,] array = new int[m, n];
    for(int i=0; i < m; i++) {
        for(int j=0; j < n; j++) {
            array[i, j] = new Random().Next(1, 10);
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

// поиск и вывод значения элемента массива
void GetElementArrayToIndex(int row, int col, int[,] array) {

    if(row > array.GetLength(0) || col > array.GetLength(1)) {
        Console.WriteLine("Ошибка: Выход за пределы массива!");
    } else {
        PrintArray(array);
        Console.WriteLine($"Элемент массива [{row},{col}] = {array[row, col]}");
    }

}

Console.Write("Введите номер индекса строки массива: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер индекса столбца массива: ");
int col = Convert.ToInt32(Console.ReadLine());

// создаем массив
int[,] array = GetArray(4, 4);

GetElementArrayToIndex(row, col, array);