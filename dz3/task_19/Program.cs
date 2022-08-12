/*
Задача 19.
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Clear();
Console.WriteLine("***** DZ_task_19 *****");

Console.Write("Введите целое число N: ");
int num = Convert.ToInt32(Console.ReadLine());

int palindromeCalculation(int num) {
    int res = 0;
    int d = 0;
    while (num > 0) {
        d = num % 10;
        res = res * 10 + d;
        num = num / 10;
    }
    return res;
}

if(num == palindromeCalculation(num)) {
    Console.WriteLine($"Число {num} является палиндромом!");
} else {
    Console.WriteLine($"Число {num} не является палиндромом!");
}