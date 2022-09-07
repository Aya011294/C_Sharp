// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите любое число: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int power = int.Parse(Console.ReadLine());
 
int Power(int n, int pow)
{
    if(pow == 0)
        return 1;

    return n * Power(n, pow - 1);
}
 
Console.WriteLine($"{number} ^ {power} = " + Power(number, power));