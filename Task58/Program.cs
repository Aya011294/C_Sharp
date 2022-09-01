/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int m = ReadInt("Введите количество строк матрицы: ");
int n = ReadInt("Введите количество столбцов матрицы: ");

int[,] firstarray = new int[m, n];
FillArray2D(firstarray);
PrintArray2D(firstarray);
int[,] secondarray = new int[m, n];
FillArray2D(secondarray);
PrintArray2D(secondarray);
int[,] resultarray = new int[m, n];

MultiplyMatrix(firstarray, secondarray, resultarray);
Console.WriteLine("Произведение матриц:");

void MultiplyMatrix(int[,] firstarray, int[,] secondarray, int[,] resultarray)
{
  for (int i = 0; i < firstarray.GetLength(0); i++)
  {
    for (int j = 0; j < firstarray.GetLength(1); j++)
    {
      int sum = 0;
      for (int temp = 0; temp < firstarray.GetLength(1); temp++)
      {
        sum += firstarray[i,temp] * secondarray[temp,j];
      }
      resultarray[i,j] = sum;
    }
  }
}
PrintArray2D(resultarray);

void FillArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
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