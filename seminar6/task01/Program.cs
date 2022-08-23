// See https://aka.ms/new-console-template for more information

int[] GetArray(int size, int minValue,  int maxValue) {
    int[] arr = new int[size];
    for(int i=0; i <size; i++) {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}

int[] ReversArray(int[] arr) {
    int[] result = new int[arr.Length];
    for(int i=0; i<arr.Length; i++) {
        result[i] = arr[arr.Length-1-i];
    }
    return result;
}

void PrintArray(int[] arr) {
    //for(int i=0; i<arr.Length; i++) {
    //    Console.Write($" {arr[i]} ");
    //}
    //Console.WriteLine();
    Console.WriteLine(String.Join(", ", arr));
}

int[] array = GetArray(10,0,100);
PrintArray(array);
PrintArray(ReversArray(array));
