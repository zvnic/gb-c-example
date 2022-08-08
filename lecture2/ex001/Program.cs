// See https://aka.ms/new-console-template for more information
Console.WriteLine("#Function");

int[] array = {1,2,3,4,5,6,7,8,9};

int Max(int arg1, int arg2, int arg3) {
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int max = 0;
for(int i=0; i<=(array.Length/3); i++){
    max = Max(array[i], array[i+1], array[i+2]);
}

Console.WriteLine("max= " + max);
