// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int randomNumber = GetRandomNumber(100, 999);
Console.WriteLine(randomNumber);
Console.WriteLine(DeleteSecondDigit(randomNumber));
int DeleteSecondDigit(int number)
{
    
    int first = number / 10;
    int second = first % 10;
    return second;
}
int GetRandomNumber(int min, int max)
{
    return new Random().Next(min, max + 1);
}

