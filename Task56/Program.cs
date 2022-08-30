// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int m = ReadInt("Введите количество строк: ");
int n = ReadInt("Введите количество столбцов: ");
int[,] array = new int[m, n];
FillArray2D(array);
PrintArray2D(array);

int min = 0;
int sum = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int temp = SumLineElements(array, i);
  if (sum > temp)
  {
    sum = temp;
    min = i;
  }
}
Console.WriteLine($"{min+1} - строкa с наименьшей суммой ({sum}) элементов ");

int SumLineElements(int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i,j];
  }
  return sum;
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