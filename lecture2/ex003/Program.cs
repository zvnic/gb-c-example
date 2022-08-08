// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


void FillArray(int[] collection){
    int length = collection.Length;
    int index = 0;

    while(index < length) {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] collection) {
    int length = collection.Length;
    int position = 0;
    while(position < length) {
        Console.WriteLine(collection[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) 
{
    int length = collection.Length;
    int index = 0;
    int position = -1;

    while(index < length) {
        if(collection[index] == find) {
            position = index;
            break;
        }

        index++;
    }

    return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[5] = 4;
PrintArray(array);

int pos = IndexOf(array, 444);
Console.WriteLine("Pos=" + pos);
