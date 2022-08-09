/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Clear();
Console.WriteLine("#task13");

int[] arrayNumber = {645, 78, 32679, 3478, 8123, 8124, 567, 78946, 84, 123456, 7654321, 89653146};
int result = 0;
int digitIndex = 3;

for(int i=0; i < arrayNumber.Length; i++)
{

    result = getNumberByIndex(arrayNumber[i], digitIndex);

    if(result == -1) {
        Console.WriteLine($"{arrayNumber[i]} -> третьей цифры нет!");
    } else {
        Console.WriteLine($"{arrayNumber[i]} -> {result}");
    }
    
}

int getNumberByIndex(int num, int index) 
{
    if(num.ToString().Length < 3) {
        return -1;
    } else {
        // преобразуем char а цифру
        return Convert.ToInt32(num.ToString()[index-1]-'0');
    }
}