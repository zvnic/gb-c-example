// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int Factorial(int n) {
    // 1! = 1
    // 0! = 1
    if(n ==1) return 1;
    else return n * Factorial(n-1);
}
int Fibonacci(int n) {
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

Console.WriteLine($"Factorial = {Factorial(5)}");

for(int i=0; i < 10; i++){
    Console.WriteLine($"Fibonacci={Fibonacci(i)}");
}