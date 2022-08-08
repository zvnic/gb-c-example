// See https://aka.ms/new-console-template for more information

int num1 = new Random().Next(10, 99);
int num2 = new Random().Next(10, 999);

if(num1%num2 == 0) Console.WriteLine($"{num1} - {num2} = кратно");
else Console.WriteLine($"{num1} - {num2} = не кратно");