// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
// каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = ReadInt("Введите количество строк: ");
int n = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[m, n];
FillArray2D(numbers);
PrintArray2D(numbers);
 
 Console.Write("Cреднее арифметическое:\n");
for (int i = 0; i < n; i++)
{
  double arithmeticMean = 0;
  for (int j = 0; j < m; j++)
  {
    arithmeticMean += numbers[j, i];
  }
  arithmeticMean = Math.Round(arithmeticMean / m, 1);
  Console.WriteLine($"столбца № {i+1} {arithmeticMean}");
}

int[,] TransformationArrayWhole (double[,] array)
{
  int[,] numbers = new int[array.GetLength(0), array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
     numbers[i, j] = Convert.ToInt32(array[i, j]);
    }
  }
  return numbers;
}

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