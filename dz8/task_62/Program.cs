/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
Console.Clear();
Console.WriteLine("#Task-62");

// вывод значений массива
void PrintArray(int[,] array) {
    for(int i=0; i < array.GetLength(0); i++) {
        for(int j=0; j < array.GetLength(1); j++) {
            if(array[i, j] < 10) Console.Write($" 0{array[i, j]}");
            else Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
}

// инициализация массива и заполнение 
// последовательными числами по спирали
int[,] GetArraySpiralValue(int size) {
    int[,] array = new int[size, size];
    // точки начала и конца сторон квадрата
    int startA = 0, finishA = 0, startB = 0, finishB = 0;
    int count = 1;
    int i = 0;
    int j = 0;
    while(count <= Math.Pow(size, 2)) {
        array[i,j] = count;
        // движение вправо
        if(i == startA && j < size - finishB - 1) ++j;
        else 
        // движение вниз
        if (j == size - finishB - 1 && i < size - finishA - 1) ++i;
        else 
        // движение влево
        if (i == size - finishA -1 && j > startB) --j;
        else --i;

        // отступаем от краев пройденного пути
        if ((i == startA + 1) && (j == startB) && (startB != size - finishB - 1)){
            ++startA;
            ++finishA;
            ++startB;
            ++finishB;
        }

        ++count;
    }

    return array;
}

PrintArray(GetArraySpiralValue(4));