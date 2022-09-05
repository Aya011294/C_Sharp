// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int m = ReadInt("Введите количество строк: ");
int n = ReadInt("Введите количество столбцов: ");

int[,] firstarray = new int[m, n];
FillArray2D(firstarray);
int temp = 1;
int i = 0;
int j = 0;

while (temp <= firstarray.GetLength(0) * firstarray.GetLength(1))
{
  firstarray[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < firstarray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= firstarray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > firstarray.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray2D(firstarray);

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
      if (array[i,j] / 10 <= 0)
       Console.Write($" {array[i,j]} ");
      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
