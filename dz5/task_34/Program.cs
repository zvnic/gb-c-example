/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Clear();
Console.WriteLine("@Task_34");

// инициализация массива
int[] InitArray(int arraySize, int minValue, int maxValue) {
    int[] arr = new int[arraySize];
    for(int i=0; i < arr.Length; i++) {
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
}

// делаем красивый вывод массива
void PrintArray(int[] arr) {
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++) {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length-1]}]");
}

// четные числа в массиве
int EvenNumberArrayElement(int[] arr) {
    int countEven = 0;
    foreach(int i in arr) {
        if(i % 2 == 0) countEven++;
    }
    return countEven;
}

int[] array = InitArray(6, 100, 999);

PrintArray(array);

Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве {EvenNumberArrayElement(array)}");

