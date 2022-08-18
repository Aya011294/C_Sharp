/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int numberA = ReadInt("Введите число А - ");
int numberB = ReadInt("Введите число B - ");
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int Exponentiation(int numberA, int numberB)
{
  int result = 1;
  for(int i=1; i <= numberB; i++)
  {
    result = result * numberA;
  }

    return result;
}
int result = Exponentiation(numberA, numberB);
Console.WriteLine("Ответ: " + result);
