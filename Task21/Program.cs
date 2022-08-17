/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53 */

int a1 = Coordinate("a1", "A");
int a2 = Coordinate("a2", "A");
int a3 = Coordinate("a3", "A");
int b1 = Coordinate("b1", "B");
int b2 = Coordinate("b2", "B");
int b3 = Coordinate("b3", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double a1, double b1, 
                double a2, double b2, 
                double a3, double b3)
                {
  return Math.Sqrt(Math.Pow((b1-a1), 2) + 
                   Math.Pow((b2-a2), 2) + 
                   Math.Pow((b3-a3), 2));
}

double segmentLength =  Math.Round (Decision(a1, b1, a2, b2, a3, b3), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");



