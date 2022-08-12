// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int num = 1234567;

if(num > 99) {
    while(num > 999)
    {
        num = num /10;
    }
    Console.WriteLine(num%10);
} else {
    Console.WriteLine("третьей цифры нет!");
}