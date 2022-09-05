
int[,,] array3D = { { { 99, 77, 21 }, { 96, 43, 78 } }, { { 78, 45, 45 }, { 23, 56, 76 } }, };

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

