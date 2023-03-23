double[,] array = new double[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.Write('[');
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j]);
        Console.Write(' ');
    }
    Console.WriteLine(']');
}

double[] averange = new double[array.GetLength(1)];
for (int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        averange[j] = averange[j] + array[i, j];
    }
}

for (int i = 0; i < averange.Length; i++)
    Console.Write($" {Math.Round(averange[i] / array.GetLength(0), 1)}");