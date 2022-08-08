Console.Clear();
Console.WriteLine("#task13");

int[] arrayNumber = {645, 78, 32679, 3478, 8123, 565, 78946, 84};

int result = 0;

for(int i=0; i < arrayNumber.Length; i++) {

    if (arrayNumber[i] < 100) {
        result = -1;
    }

    if(arrayNumber[i] >= 100 && arrayNumber[i] <= 999) {
        result = arrayNumber[i]%100%10;
    }

    if(arrayNumber[i] > 999 && arrayNumber[i] <= 9999) {
        result = arrayNumber[i]%1000%100/10;
    }

    if(arrayNumber[i] > 9999) {
        result = arrayNumber[i]%1000/100;
    }

    if(result == -1) 
    {
        Console.WriteLine($"{arrayNumber[i]} -> третьей цифры нет!");
    } else {
        Console.WriteLine($"{arrayNumber[i]} -> {result}");
    }
    
}