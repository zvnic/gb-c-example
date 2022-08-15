/*
Напишите программу, которая принимает 
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/
Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {num} имеет {num.ToString().Length} цифр(ы)");