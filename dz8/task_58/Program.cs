/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.Clear();
Console.WriteLine("#Task-58");

// инициализация массива и заполнение случайными числами
int[,] GetArray(int m, int n) {
    int[,] array = new int[m, n];
    for(int i=0; i < m; i++) {
        for(int j=0; j < n; j++) {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

// вывод значений массива
void PrintArray(int[,] array) {
    for(int i=0; i < array.GetLength(0); i++) {
        for(int j=0; j < array.GetLength(1); j++) {
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}

// вывод результата умножения матрицы А на матрицу В
void MatrixMultiplication(int[,] matrixA, int[,] matrixB) {
    int[,] matrixC = new int[matrixB.GetLength(0), matrixB.GetLength(1)];

    // проверка числа столбцов и строк
    if(matrixA.GetLength(1) == matrixB.GetLength(0)) {
        for(int i=0; i < matrixC.GetLength(0); i++) {
            for(int j=0; j < matrixC.GetLength(1); j++) {
                for(int k=0; k < matrixC.GetLength(1); k++) {
                    // перемножаем элементы матрицы
                    matrixC[i,j] += matrixA[i,k] * matrixB[k,j];
                }
            }
        }
        PrintArray(matrixC);
    } else {
        Console.WriteLine("Ошибка: число столбцов матрицы A не равно числу строк матрицы B.");
    }
}

//int[,] matrixA = {{2, 4}, {3, 2}};
//int[,] matrixB = {{3, 4}, {3, 3}};

int[,] matrixA = GetArray(2,2);
int[,] matrixB = GetArray(2,2);

PrintArray(matrixA);
Console.WriteLine("  x");

PrintArray(matrixB);
Console.WriteLine("  =");

MatrixMultiplication(matrixA, matrixB);