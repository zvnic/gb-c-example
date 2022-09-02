/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
 в промежутке от M до N от большего к меньшему.
M = 1; N = 5. -> ""5, 4, 3, 2, 1""
M = 4; N = 8. -> ""8, 7, 6, 5, 4""
*/
Console.Clear();
Console.WriteLine("#Task-64");

int GetAllNaturalNumbers(int m, int n) {
    if(n < m) return 1;
    else {
        Console.Write($"{n} ");
        return GetAllNaturalNumbers(m, n - 1) - n;
    }
}

void CheckNumbers(int m, int n) {
    if (m > n) Console.WriteLine($"Ошибка: m[{m}] > n[{n}]");
    else {
        GetAllNaturalNumbers(m, n);
    }
}


Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

CheckNumbers(m, n);