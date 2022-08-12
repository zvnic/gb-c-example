/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.Clear();
Console.WriteLine("***** DZ_task_21 *****");

int[] dotA = new int[3];
int[] dotB = new int[3];

Console.WriteLine("Введите координаты точки A:");
Console.Write("Ax:");
dotA[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Ay:");
dotA[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Az:");
dotA[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.Write("Bx:");
dotB[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("By:");
dotB[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Bz:");
dotB[2] = Convert.ToInt32(Console.ReadLine());

double res = Math.Sqrt(
    Math.Pow((dotA[0] - dotB[0]), 2) + 
    Math.Pow((dotA[1] - dotB[1]), 2) + 
    Math.Pow((dotA[2] - dotB[2]), 2)
);

Console.WriteLine($"Расстояние между точками координат A({dotA[0]},{dotA[1]},{dotA[2]}), B({dotB[0]},{dotB[1]},{dotB[2]}) = {Math.Round(res, 2)}");
