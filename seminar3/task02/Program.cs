﻿/*
Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

Console.WriteLine("#Task_22");

int n = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= n; i++) {
    Console.Write($"{i * i}, ");
}
