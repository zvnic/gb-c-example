/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
Console.Clear();
Console.WriteLine("#Task-47");

double[,] GetArray(int m, int n, int max) {
    double[,] array = new double[m, n];
    for(int i=0; i < m; i++) {
        for(int j=0; j < n; j++) {
            array[i, j] = Math.Round(new Random().NextDouble() * 20 - 10, 1);
        }
    }
    return array;
}

void PrintArray(double[,] array) {
    for(int i=0; i < array.GetLength(0); i++) {
        for(int j=0; j < array.GetLength(1); j++) {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
    
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

double[,] array = GetArray(rows, cols, 100);

PrintArray(array);
