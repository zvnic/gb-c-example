/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.Clear();
Console.WriteLine("#Task-43");

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double CalculateX(double b1, double k1, double b2, double k2) {
    return (b2 - b1) / (k1 - k2);
}

double CalculateY(double b1, double k1, double b2, double k2) {
    return (k2*b1-k1*b2)/(k2-k1);
}

void CheckPoint(double b1, double k1, double b2, double k2) {
    double x = (b2 - b1) / (k1 - k2);
    double y = (k2 * b1 - k1 * b2) / (k2 - k1);
    
    if(k1==k2) Console.Write("C данными значениями прямые не пересекаются!");
    else Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> точка пересечения ({x},{y})");
}

CheckPoint(b1, k1, b2, k2);


