

    int GetRandomNumberInRange(int min, int max)
    {
        int result = new Random().Next(min, max + 1);
        return result;
    }

    int GetMaxDigitFromNumber(int number)
    {
        int result = number / 10;
        int secondDigit = number % 10;
        if(secondDigit > result) {
            result = secondDigit;
        }
        return result;
    }

//Console.WriteLine("Random number=" + GetRandomNumberInRange(10, 99));
int num = GetRandomNumberInRange(10, 99);
Console.WriteLine($"max {num} digital={GetMaxDigitFromNumber(num)}");