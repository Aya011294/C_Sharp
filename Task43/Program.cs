// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] array = new double[2, 2];
double[] point = new double[2];

void InputCoefficients(){
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.Write($"Коэффициенты {i+1}-го уравнения:\n");
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if(j==0) Console.Write($"k: ");
      else Console.Write($"b: ");
      array[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] array)
{
  point[0] = (array[1,1] - array[0,1]) / (array[0,0] - array[1,0]);
  point[1] = point[0] * array[0,0] + array[0,1];
  return point;
}

void OutputResponse(double[,] array)
{
  if (array[0,0] == array[1,0] && array[0,1] == array[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (array[0,0] == array[1,0] && array[0,1] != array[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Decision(array);
    Console.Write($"\nТочка пересечения прямых: ({point[0]}, {point[1]})");
  }
}

InputCoefficients();
OutputResponse(array);
