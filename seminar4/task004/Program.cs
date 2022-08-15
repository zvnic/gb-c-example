// See https://aka.ms/new-console-template for more information


int[] arr = new int[8];

for(int i=0; i < arr.Length; i++) {
    arr[i] = new Random().Next(0,2);
}

for(int i=0; i < arr.Length; i++) {
    Console.Write($"{arr[i]} ");
}

