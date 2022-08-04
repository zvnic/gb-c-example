internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("#Task-04");

        int max = 0;

        Console.WriteLine("Введите первое целое число:");
        int numberA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе целое число:");
        int numberB = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите третье целое число:");
        int numberС = Convert.ToInt32(Console.ReadLine());

        if(numberA > max) max = numberA;
        if(numberB > max) max = numberB;
        if(numberС > max) max = numberС;

        Console.WriteLine($"Из чисел({numberA},{numberB},{numberС}) max = {max}");
    }
}