// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

int ReadInt(string message)
{
    Console.Write(message);   
    return Convert.ToInt32(Console.ReadLine());
}
int number = ReadInt("Введите трехзначное число: ");
Console.WriteLine(DeleteSecondDigit(number));
int DeleteSecondDigit(int number)
{
    int first = number / 10;
    int second = first % 10;
    return second;
}


