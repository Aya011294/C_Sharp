// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите любое число n: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите любое число m: ");
int m = int.Parse(Console.ReadLine());
int count = m;

if (m > n) 
{
  m = n; 
  n = count;
}
Sum(m, n, count=0);

void Sum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма в промежутке от M до N  {sum} ");
    return;
  }
  Sum(m, n - 1, sum);
}

