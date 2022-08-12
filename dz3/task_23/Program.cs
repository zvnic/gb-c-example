﻿/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.Clear();
Console.WriteLine("***** DZ_task_23 *****");

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"{n} -> 1");

for(int i=2; i <= n; i++) {
    Console.Write($", {Math.Pow(i, 3)}");
}