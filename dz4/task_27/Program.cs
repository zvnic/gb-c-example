/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.Clear();
Console.WriteLine("#Task_27");

Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

// вычисляем сумму цифр в числе
int GetSumDigit(int num) {
    int sum = 0;
    for(int i = num ; i >0; i /= 10) {
        sum += i % 10;
    }
    return sum;
}

void PrintResult(int num) {
    Console.WriteLine($"В числе {num} сумма цифр равна - {GetSumDigit(num)}");
}

PrintResult(num);
