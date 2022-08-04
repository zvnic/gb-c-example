internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("#Task-06");

        Console.WriteLine("Введите целое число:");
        int number = Convert.ToInt32(Console.ReadLine());

        if(number%2 == 0) {
            Console.WriteLine($"Число {number} - четное!");
        } else {
            Console.WriteLine($"Число {number} - не четное!");
        }
    }
}