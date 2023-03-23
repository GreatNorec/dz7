double[,] array = new double[3, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.Write('[');
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Math.Round((new Random().NextDouble()) * 10 * Math.Pow((-1), new Random().Next(0, 2)), 1);
        Console.Write(array[i, j]);
        Console.Write(' ');
    }
    Console.WriteLine(']');
}

Console.Write("Введите строку и стобец элемента массива: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Replace(",", "").Split(), int.Parse);

if (arr[0] > array.GetLength(0) || arr[1] > array.GetLength(1)) Console.WriteLine($"Элемента с индексам {arr[0]} и {arr[1]} не существует");
else Console.WriteLine($"Значение нужного элемента {array[arr[0], arr[1]]}");