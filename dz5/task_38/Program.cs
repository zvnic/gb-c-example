/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
Console.Clear();
Console.WriteLine("#Task_38");

// инициализация массива
double[] InitArray(int arraySize, double minValue, double maxValue) {
    double[] arr = new double[arraySize];
    for(int i=0; i < arr.Length; i++) {
        double random = new Random().NextDouble() * (maxValue - minValue) + minValue;
        arr[i] = Math.Round(random, 2);
    }
    return arr;
}

// делаем красивый вывод массива
void PrintArray(double[] arr) {
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++) {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length-1]}]");
    Console.WriteLine();
}

// максимальное значение в массиве
double IndexMaxValueArray(double[] arr) {
    double index = arr[0];
    foreach(double i in arr) {
        if(i > index) index = i;
    }
    return index;
}

// минимальное значение в массиве
double IndexMinValueArray(double[] arr) {
    double index = arr[0];
    foreach(double i in arr) {
        if(i < index) index = i;
    }
    return index;
}

double[] array = InitArray(5, 1.0, 99.0);
double maxValue = IndexMaxValueArray(array);
double minValue = IndexMinValueArray(array);
double differenceValue = maxValue - minValue;

PrintArray(array);

Console.WriteLine($"Max значение элемента массива = {maxValue}");
Console.WriteLine($"Min значение элемента массива = {minValue}");
Console.WriteLine($"Разницу между Max и Min элементами массива = {Math.Round(differenceValue, 2)}");
