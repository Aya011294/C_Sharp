/* Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.*/


/* int size = 12;
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int sumNegative = 0;
int sumPositive = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
        sumPositive += numbers[i];
    else
        sumNegative += numbers[i];
}

Console.WriteLine($"Сумма положительных элементов равна {sumPositive}\n" +
                   $"Сумма отрицательных равна {sumNegative}");

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
} */

/* Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 

int size = 4;
int[] numbers = new int[size];
int[] newNumber = new int[size];
ArrayRandom(numbers);
for (int i = 0; i < numbers.Length; i++)
{
    newNumber[i] = numbers[i] * -1;
}
PrintArray(numbers);
Console.WriteLine();
PrintArray(newNumber);

void ArrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int size = 10;
int[] numbers = new int[size];
ArrayRandom(numbers);
PrintArray(numbers);
Console.WriteLine();
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i]==number)
{
    Console.WriteLine("В массиве присутствует введенное вами число");
    break;
}
else if(i == numbers.Length-1)
{
    Console.WriteLine("В массиве не присутствует введенное вами число");
}
}


void ArrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 5);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    32;

    int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = -numbers[i];
}
PrintArray(numbers);


void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

33;
nt size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int findNumber = ReadInt("Введите искомое число: ");

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] == findNumber)
    {
        Console.WriteLine("Да");
        return;
    }
}
Console.WriteLine("Нет");

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

и еще одно решение 

nt size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int findNumber = ReadInt("Введите искомое число: ");
bool existNumber = false;

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] == findNumber)
    {
        existNumber = true;
        break;
    }
}
if(existNumber)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5

int[] ourArray = new int[123];
int count = 0;
ArrayRandom(ourArray);
PrintArray(ourArray);

for (int i = 0; i < ourArray.Length; i++)
{
    if (ourArray[i] >= 10 && ourArray[i] <= 99)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine(count);

void ArrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 500);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21

int size = 123;
int[] numbers = new int[size];
int min = 10;
int max = 99;
int count = 0;

FillArrayRandomNumbers(numbers);
PrintArray(numbers);

for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] >= min && numbers[i] <= max)
        count++;
}
Console.WriteLine($"В массиве {count} чисел на отрезке от {min} до {max}");


void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 150);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int[] pairs;
int pairsSize = numbers.Length / 2;
if(numbers.Length % 2 == 0)
{
    pairs = new int[pairsSize];
}
else
{
    pairs = new int[pairsSize + 1];
    pairs[pairs.Length - 1] = numbers[pairsSize];
}

for(int i = 0; i < pairsSize; i++)
{
    pairs[i] = numbers[i] * numbers[numbers.Length - 1 - i];
}
PrintArray(pairs);

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 150);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

*/