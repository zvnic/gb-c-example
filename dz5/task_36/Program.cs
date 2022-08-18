/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.Clear();
Console.WriteLine("#Task_36");

// инициализация массива
int[] InitArray(int arraySize, int minValue, int maxValue) {
    int[] arr = new int[arraySize];
    for(int i=0; i < arr.Length; i++) {
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
}

// сумма значений нечетных элементов массива 
int GetSumOddValueIndex(int[] arr) {
    int sumValueElements = 0;
    for(int i=0; i < arr.Length; i++) {
        if(i % 2 != 0) sumValueElements += arr[i];
    }
    return sumValueElements;
}

// делаем красивый вывод массива
void PrintArray(int[] arr) {
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++) {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length-1]}]");
    Console.WriteLine();
}

int[] array = InitArray(4, 1, 99);
int result = GetSumOddValueIndex(array);

PrintArray(array);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {result}");
