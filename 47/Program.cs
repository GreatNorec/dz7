double[,] array = new double[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.Write('[');
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Math.Round((new Random().NextDouble()) * (new Random().Next(-9, 9)), 1);
        Console.Write(array[i, j]);
        Console.Write(' ');
    }
    Console.WriteLine(']');
}