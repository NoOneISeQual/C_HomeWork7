void InputArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr [i, j] = new Random().Next(1,11);
        }
    }
}

void PrintArray (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void Sum (int[,] arr)
{
    Console.WriteLine("<_______________________________________________>");
    Console.WriteLine("Стреднее арифметическое каждого столбца: ");
    for (int j = 0; j <arr.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
        average = (average + arr[i, j]);
        }
        Console.Write($"{average / arr.GetLength(0)} \t");
    }
}

Console.Clear();
Console.WriteLine("Введите размерность массива (строка=>столбец) через пробел: ");
int [] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int [,] Array = new int [size[0], size[1]];
InputArray(Array);
PrintArray(Array);
Sum(Array);
