﻿/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.(необязательная)
m = 2, n = 3 -> A(m,n) = 29
*/
Console.Clear();
Console.WriteLine("#Task-68");

int funcAkkerman(int m, int n) {
    if (m == 0) {
        return n + 1;
    } else if((m > 0) && (n == 0)) {
        return funcAkkerman(m - 1, 1);
    } else if((m > 0) && (n > 0)) {
        return funcAkkerman(m - 1, funcAkkerman(m, n - 1));
    } else
        return n + 1;
}

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Функция Аккермана = {funcAkkerman(3, 2)} ");