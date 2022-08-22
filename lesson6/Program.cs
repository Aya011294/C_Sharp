/* Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

for (int i = 0; i < numbers.Length / 2; i++)
{
    int temp = numbers[i];
    numbers[i] = numbers[numbers.Length - 1 - i];
    numbers[numbers.Length - 1 - i] = temp;
}
PrintArray(numbers);

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
} 

Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10

int sideA = ReadInt("Введите длину стороны A: ");
int sideB = ReadInt("Введите длину стороны B: ");
int sideC = ReadInt("Введите длину стороны C: ");

bool isCheckSideA = sideA < sideB + sideC;
bool isCheckSideB = sideB < sideA + sideC;
bool isCheckSideC = sideC < sideB + sideA;

if(isCheckSideA && isCheckSideB && isCheckSideC)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10

nt number = ReadInt("Введите число: ");
int baseNumber = 2;
string result = string.Empty;

while(number > 0)
{
    result = number % baseNumber + result;
    number /= baseNumber;
}
Console.WriteLine(result);


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());

int inputNumber = ReadInt("Введите число: ");
int baseNumber = 2;
int number = inputNumber;
int size = 0;

while(number > 0)
{
    size++;
    number /= baseNumber;
}

int[] result = new int[size];
number = inputNumber;
for(int i = 0; i < result.Length; i++)
{
    result[result.Length - 1 - i] = number % baseNumber;
    number /= baseNumber;
}
PrintArray(result);


void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());

Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8

nt size = ReadInt("Сколько чисел Фиббоначи вывести?: ");
int[] numbersFibonacci = new int[size];
if(size > 0)
    numbersFibonacci[0] = 0;
if(size > 1)
    numbersFibonacci[1] = 1;

for(int i = 2; i < numbersFibonacci.Length; i++)
{
    numbersFibonacci[i] = numbersFibonacci[i - 1] + numbersFibonacci[i - 2];
}
PrintArray(numbersFibonacci);

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
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

int size = ReadInt("Сколько чисел Фиббоначи вывести?: ");
int first = 0;
int second = 1;
Console.Write($"{first} {second} ");
for(int i = 2; i < size; i++)
{
    int temp = second;
    second += first;
    first = temp;
    Console.Write(second + " ");
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
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


Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

nt size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int[] copyNumbers = CopyArray(numbers);
PrintArray(copyNumbers);

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }
    return newArray;
}

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
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