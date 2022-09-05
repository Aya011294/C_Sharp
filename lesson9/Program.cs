// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

int NaturalRange(int min, int max)
{
    if (min > max)
    {
        int temp = max;
        max = min;
        min = temp;
    }

    
        if (max == min)
            return min;
        else
        {
            Console.Write($"{NaturalRange(min, max - 1)} ");
        }
        return max;
    
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int m = ReadInt("Введите минимальное значение в ряду: ");
int n = ReadInt("Введите максимальное значение в ряду: ");

Console.Write(NaturalRange(m, n) + " ");

//////////////////

int Number(int m, int n)
{
    if (n == m)
        return m;
    Console.Write(Number(m, n-1) + " ");
    return n;
}


int Number2(int m, int n)
{
    if (n == m)
        return m;
    Console.Write(Number2(m, n+1) + " ");
    return n;
}


Console.WriteLine("Введите первое число:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int N = Convert.ToInt32(Console.ReadLine());
if (M < N)
    Console.Write(Number(M, N));
else
    Console.Write(Number2(M, N));
    ///////////////////////////


    Console.Write("Задайте число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте число n: ");
int n = int.Parse(Console.ReadLine());
 
NaturalNumber(m, n);
 
void NaturalNumber(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m}, ");
        NaturalNumber(m + 1, n);
    }
    if (m > n)
    {
        Console.Write($"{m}, ");
        NaturalNumber(m - 1, n);
    }
    if (m == n) 
    {
        Console.Write($"{m} ");
    }
}


//////////////////

Console.Write("Задайте число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте число n: ");
int n = int.Parse(Console.ReadLine());
 
NaturalNumber(m, n);
 
void NaturalNumber(int m, int n)
{
    if (m < n)
    {
        Console.Write($"{m}, ");
        NaturalNumber(m + 1, n);
    }
    if (m > n)
    {
        Console.Write($"{m}, ");
        NaturalNumber(m - 1, n);
    }
    if (m == n) 
    {
        Console.Write($"{m} ");
    }
}

////////////

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.рекурсия
// 453 -> 12
// 45 -> 9

int DigitSum (int number)
{
    if (number < 10 ) 
        return number;
    else
    {
        int sum = number % 10; 
        sum += DigitSum(number/10);
        return sum;
    } 
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int n = ReadInt("Введите число: ");
Console.Write ($"Cумма чисел в вашем числе: {DigitSum(n)}");//////

Console.Write("Введите любое число: ");
int n = int.Parse(Console.ReadLine());
 
int SumDigits(int n)
{
    if (n > 10) 
        return n % 10 + SumDigits(n / 10);
    
    return n;
}
 
Console.WriteLine("Сумма цифр заданного числа равна: " + SumDigits(n));
////////////////////


// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число 
// А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

double Power (int n, int p)
{
    if (p==0)
        return 1;
    else
    {
        double res = 1;
        p--;
        res = n * Power(n,p);
        return res;
    }
}

int number = ReadInt("Введите число: ");
int power = ReadInt("Введите степень, в которую надо возвести: ");
Console.WriteLine(Power(number,power));

//////////////


Console.Write("Введите любое число: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите степень: ");
int power = int.Parse(Console.ReadLine());
 
int Power(int n, int pow)
{
    if(pow == 0)
        return 1;

    return n * Power(n, pow - 1);
}
 
Console.WriteLine($"{number} ^ {power} = " + Power(number, power));