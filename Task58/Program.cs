/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int m = ReadInt("Введите количество строк первой матрицы: ");
int n = ReadInt("Введите количество столбцов первой матрицы: ");

int[,] firstMartrix = new int[m, n];
Console.WriteLine($"матрица первая:");
FillArray2D(firstMartrix );
PrintArray2D(firstMartrix );

int a = ReadInt("Введите количество строк второй матрицы: ");
int b = ReadInt("Введите количество столбцов втрой матрицы: ");
int[,] secomdMartrix = new int[a, b];
Console.WriteLine("Вторая матрица:");
FillArray2D(secomdMartrix);
PrintArray2D(secomdMartrix);

int[,] resultMatrix = new int[m, a];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine("Произведение матриц:");

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}
PrintArray2D(resultMatrix);

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