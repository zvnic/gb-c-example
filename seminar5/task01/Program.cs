/*

*/
Console.Clear();
Console.WriteLine("Hello, World!");

int[] InitArray(int arraySize, int minValue, int maxValue) {
    int[] arr = new int[arraySize];

    for(int i=0; i < arr.Length; i++) {
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
}

void PrintArray(int[] arr) {
    foreach(int i in arr) {
        Console.Write($"{i} ");
    }
}

int[] array1 = InitArray(12, -9, 9);


int positiveSum = 0;
int negativeSum = 0;
foreach(int i in array1) {
    if(i>0) positiveSum += i;
    else negativeSum += i;
}


PrintArray(array1);

Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел ={positiveSum}, Сумма отрицательных чисел ={negativeSum}");