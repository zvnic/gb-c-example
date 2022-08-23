/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.Clear();
Console.WriteLine("Task-41");

int[] ConvertStringToInteger(string[] str) {
    int[] arr = new int[str.Length];
    for(int i=0; i < str.Length; i++) {
        arr[i] = Convert.ToInt32(str[i]);
    }
    return arr;
}

int CounterGreaterZero(int[] arr) {
    int count = 0;
    foreach(int el in arr) {
        if(el > 0) count++;
    }
    return count;
}

Console.Write("Введите целые числа через запятую: ");
string numbers = Console.ReadLine();

// парсим строку в массив значений и 
// конвертируем в массив целых чисел
int[] numberArray = ConvertStringToInteger(numbers.Split(','));

Console.WriteLine($"Количество чисел больше нуля = {CounterGreaterZero(numberArray)}");
