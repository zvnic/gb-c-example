/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму чётных чисел
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 56
M = 4; N = 8. -> 18
*/
Console.Clear();
Console.WriteLine("#Task-66");


int GetSumOfPrivateNumbers(int m, int n) {
    if (m <= n) {
        if (m % 2 == 0) {
            return m + GetSumOfPrivateNumbers(m + 2, n);
        } else {
            m = m + 1;
            return m + GetSumOfPrivateNumbers(m + 2, n);
        }
    }
    else return 0;

}

void CheckNumbers(int m, int n) {
    if (m > n) Console.WriteLine($"Ошибка: m[{m}] > n[{n}]");
    else {
        Console.WriteLine($"Сумма чётных чисел натуральных элементов в промежутке от {m} до {n} = " + GetSumOfPrivateNumbers(m, n));
    }
}
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

CheckNumbers(m, n);