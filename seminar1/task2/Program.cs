internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Введите номер дня:");
        int numberDay = Convert.ToInt32(Console.ReadLine());

        if(numberDay == 1) Console.WriteLine("Понедельник");
        else if(numberDay == 2) Console.WriteLine("Вторник");
        if(numberDay == 3) Console.WriteLine("Среда");
        if(numberDay == 4) Console.WriteLine("Четверг");
        if(numberDay == 5) Console.WriteLine("Пятница");
        if(numberDay == 6) Console.WriteLine("Суббота");
        if(numberDay == 7) Console.WriteLine("Воскресенье");

        if(numberDay <= 0 || numberDay > 7) Console.WriteLine("Нет такого дня недели!");

    }
}