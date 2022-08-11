/*
По данному натуральному числу n найдите сумму чисел 1+1/1!+1/2!+1/3!+...+1/n!  
Количество действий должно быть пропорционально n. Напишите программу, 
которая считывает значение n и выводит результат в виде действительного числа
*/
Console.WriteLine("Enter N:");
int n = Convert.ToInt32(Console.ReadLine());

double f = 1;
double res = 1;

for(int i = 1; i <= n; i++) {
    f = f * i;
    res = res + 1/f;
}

Console.Write($"{Math.Round(f=res, 2)} ");