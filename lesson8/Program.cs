/* Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

nt rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
FillArray(numbers);
PrintArray(numbers);

int firstRow = 0;
int secondRow = numbers.GetLength(0) - 1;

for (int i = 0; i < numbers.GetLength(1); i++)
{
    int temp = numbers[firstRow, i];
    numbers[firstRow, i] = numbers[secondRow, i];
    numbers[secondRow, i] = temp;
}
PrintArray(numbers);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
от Денис для Все (23:32)
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("\n");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}



Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки 
на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

nt rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
FillArray(numbers);
PrintArray(numbers);

if(rows != columns)
{
    Console.WriteLine("Транспонировать невозможно!");
    return;
}

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < i; j++)
    {
        int temp = numbers[i, j];
        numbers[i, j] = numbers[j ,i];
        numbers[j, i] = temp;
    }
}
PrintArray(numbers);
от Денис для Все (23:38)
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("\n");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
FillArray(numbers);
PrintArray(numbers);

if(rows != columns)
{
    Console.WriteLine("Транспонировать невозможно!");
    return;
}

int[,] reverseNumbers = new int[numbers.GetLength(1), numbers.GetLength(0)];
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        reverseNumbers[i, j] = numbers[j, i];
    }
}
PrintArray(reverseNumbers);
от Денис для Все (23:41)
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("\n");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/

