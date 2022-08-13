// See https://aka.ms/new-console-template for more information

int[] arr = {1,2,3,4,5,6,7,7,5,56,7,8};

void PrintArray(int[] array) {
    int count = array.Length;

    for(int i=0; i < count; i++) {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

}

void SelectionSort(int[] array) {
    for(int i=0; i <array.Length; i++) {
        int minPosition = i;
        
        for(int j= i+1; j <array.Length; j++ ) {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temp = array[i];
        array[minPosition] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

