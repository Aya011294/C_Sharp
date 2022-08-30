/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int m = ReadInt("Введите количество строк: ");
int n = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[m, n];
FillArray2D(numbers);
PrintArray2D(numbers);
 
void OrderArrayLines(int[,] numbers)
{
  for (int i = 0; i < numbers.GetLength(0); i++)
  {
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
      for (int k = 0; k < numbers.GetLength(1) - 1; k++)
      {
        if (numbers[i, k] < numbers[i, k + 1])
        {
          int temp = numbers[i, k + 1];
          numbers[i, k + 1] = numbers[i, k];
          numbers[i, k] = temp;
        }
      }
    }
  }
}
Console.WriteLine("Отсортированный массив: ");
OrderArrayLines(numbers);
PrintArray2D(numbers);
void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
