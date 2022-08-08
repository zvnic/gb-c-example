﻿/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Clear();
Console.WriteLine("#task15");

Console.WriteLine("Введите номер дня недели [1-7]:");
int numDay = Convert.ToInt32(Console.ReadLine());

string[] weekday = {
    "Понедельник - рабочий день :(",
    "Вторник - рабочий день :(",
    "Среда - рабочий день :(",
    "Четверг - рабочий день :(",
    "Пятница - крайний рабочий день :)",
    "Суббота - выходной день :)",
    "Воскресенье - выходной день :)"
    };

if(numDay < 1 || numDay > 7) {
    Console.WriteLine("Ошибка - введите номер от 1 до 7.");
} else {
    Console.WriteLine($"День недели {numDay} -> {weekday[numDay - 1]}");
}
