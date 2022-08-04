internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("#Task-02");
        
        Console.WriteLine("Введите первое целое число:");
        int numberA = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе целое число:");
        int numberB = Convert.ToInt32(Console.ReadLine());

        if(numberA > numberB){
            Console.WriteLine($"Из чисел ({numberA},{numberB}) большее число = {numberA}");
        }
        else {
            Console.WriteLine($"Из чисел ({numberA},{numberB}) большее число = {numberB}");
        }
    }
}