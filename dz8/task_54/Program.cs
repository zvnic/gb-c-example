﻿/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
Console.Clear();
Console.WriteLine("#Task-54");

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

// сортировка массива по убыванию в каждой строке
int[,] SortArrayToRow(int[,] array) {
    for(int i = 0; i < array.GetLength(0); i++) {
        for(int j = 0; j < array.GetLength(1); j++) {
            int temp = 0;
            for(int k = 1; k < array.GetLength(1); k++) {
                if (array[i,k-1] < array[i,k]) {
                    temp = array[i,k];
                    array[i,k] = array[i,k-1];
                    array[i,k-1] = temp;
                }
            }
        }
    }
    return array;
}

// создаем массив
int[,] array = GetArray(4, 4);

// выводим исходный массив
PrintArray(array);

Console.WriteLine("---------");

// выводим отсортированный по строкам массив
PrintArray(SortArrayToRow(array));