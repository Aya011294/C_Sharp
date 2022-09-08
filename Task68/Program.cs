// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите любое число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите любое число n: ");
int n = int.Parse(Console.ReadLine());
int AckermanFunc = Ackerman(m, n);

Console.Write($"Функция Аккермана {AckermanFunc} ");

int Ackerman(int m, int n)
{
  if (m == 0) 
  return n + 1;
  if (n == 0) 
  return Ackerman(m - 1, 1);
  else 
  return Ackerman(m - 1, Ackerman(m, n - 1));
}