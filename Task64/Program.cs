// // Задача 64: Задайте значения N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// N = 5. -> "5, 4, 3, 2, 1"
// N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Задайте число m: ");
int m = int.Parse(Console.ReadLine());
int n = 1;
 
NaturalNumber(m, n);
 
void NaturalNumber(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m}, не натуральное число");
        // NaturalNumber(m + 1, n);
    }
    if (m > n)
    {
        Console.Write($"{m}, ");
        NaturalNumber(m - 1, n);
    }
    if (m == n) 
    {
        Console.Write($"{m} ");
    }

}