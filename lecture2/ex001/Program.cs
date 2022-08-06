// See https://aka.ms/new-console-template for more information
Console.WriteLine("#Function");

int Max(int arg1, int arg2, int arg3) {
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

Console.WriteLine("max= " + Max(100,200,300));
