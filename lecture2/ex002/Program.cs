// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] array = {1,23,34,45,56,767,867,78,78,886};

int n = array.Length;
int find = 56;

int index = 0;

while(index < n) {
    if(array[index] == find) {
        Condole.WriteLine(index);
    }
    index++;
}