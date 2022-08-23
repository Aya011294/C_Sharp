/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76 */

double[] arraynumbers = new double[5];
for (int i = 0; i < arraynumbers.Length; i++)
{
   arraynumbers[i] = new Random().Next(1, 10);
   Console.Write(arraynumbers[i] + " ");
}
double max = arraynumbers[0];
double min = arraynumbers[0];
for (int i = 1; i < arraynumbers.Length; i++)
{
    if (max< arraynumbers[i])
    {
      max = arraynumbers[i];
    }
    if (min > arraynumbers[i])
    {
      min = arraynumbers[i];
    }
  }
double difference = max - min;
Console.WriteLine($" difference: {difference}");