﻿/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Console.Clear();
Console.WriteLine("#Task-60");


// инициализация массива и заполнение случайными числами
int[,,] GetArray(int x, int y, int z) {
    int[,,] array = new int[x, y, z];
    for(int i=0; i < x; i++) {
        for(int j=0; j < y; j++) {
            for(int k=0; k < z; k++) {
                array[i, j, k] = new Random().Next(10, 100);
            }
            
        }
    }
    return array;
}

// вывод значений массива
void PrintArray(int[,,] array) {
    for(int i=0; i < array.GetLength(0); i++) {
        for(int j=0; j < array.GetLength(1); j++) {
            for(int k=0; k < array.GetLength(2); k++) {
                Console.Write($" {array[j, k, i]} ({j}, {k}, {i})");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}


// создаем массив
int[,,] array = GetArray(2, 2, 2);

// вывод значения массива с индексом элемента
PrintArray(array);