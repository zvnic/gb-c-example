// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[,] table =new string[10, 10];

// table[0,0] table[0,1]
table[1,2] = "test";

for(int i=0; i < table.GetLength(0); i++) {
    for(int j=0; j < table.GetLength(1); j++) {
        table[i,j] = "" + new Random().Next(100);
    }
    Console.WriteLine();
}

for(int i=0; i < table.GetLength(0); i++) {
    for(int j=0; j < table.GetLength(1); j++) {
        Console.Write($" {table[i,j]} ");
    }
    Console.WriteLine();
}