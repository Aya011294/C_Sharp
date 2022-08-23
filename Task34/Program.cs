/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> */

Console.Write("Enter array number - ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [size];
FillArrayRandomNumbers (numbers);
PrintArray (numbers);
int QuantityPositive(int[] array)
{
    int evennumber = 0;
    for (int i = 0; i<array.Length; i++ )
  {
    if (array[i] % 2 == 0)
    {
      evennumber++;
    }
  }
  return evennumber;
}
int evennumber = QuantityPositive(numbers);
Console.WriteLine($"The number of even numbers in the array {evennumber}");

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 1000);
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