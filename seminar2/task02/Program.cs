
int GetRandomNumber() {
    int result = new Random().Next(100, 999);
    return result;
}

int num = GetRandomNumber();

Console.WriteLine($"{num} - {num/100}");
Console.WriteLine($"{num} - {num%100/10}");
Console.WriteLine($"{num} - {num%10}");
