/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
Console.Clear();
Console.WriteLine("#Task_29");

Console.Write("Введите размер массива:");
int arraySize = Convert.ToInt32(Console.ReadLine());

// инициализация и заполнение массива
int[] GetArrayRandomValue(int size) {
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(0, 100);
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

int[] arr = GetArrayRandomValue(arraySize);

PrintArray(arr);
