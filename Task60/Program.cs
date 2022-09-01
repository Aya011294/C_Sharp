
int[,,] array3D = { { { 66, 34, 88 }, { 27, 26, 76 } }, { { 25, 41, 64 }, { 90, 55, 51 } }, };

PrintArray3D(array3D);

void PrintArray3D(int[,,] array)
{
    int[,] newArray2D = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($" {array[i, j, k]}  ({i},{j},{k})");
            }
        }
    }
}