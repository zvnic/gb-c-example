// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

for(int i = -num; i <= num; i++)
{
    Console.WriteLine(i);
}