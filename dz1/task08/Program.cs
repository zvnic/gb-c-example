internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("#Task-08");

        Console.WriteLine("Введите целое число:");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Чётные числа [от 1 до {number}] - ");

        for(int i = 1; i <= number; i++){
            if(i%2 == 0) Console.Write($" {i} ");
        }
    }
}