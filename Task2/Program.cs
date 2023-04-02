void InputMatrix (int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++ )
        {    
            mat[i, j] = new Random().Next(1,11);
        }
    }
}

void PrintMatrix (int [,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i, j]} \t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int [] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int [,] matrix = new int[size[0], size[1]];
Console.WriteLine("Введите  позицию элемента(номер строки): ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите  позицию элемента(номер столбца): ");
int m = int.Parse(Console.ReadLine()!);
InputMatrix(matrix);
PrintMatrix(matrix);


if (n > matrix.GetLength(0)|| m > matrix.GetLength(1))
{
    Console.WriteLine("Такого позици нет, попробуйте еще раз.");
}
else
{
    Console.WriteLine($"Значение элемента {n} строки и {m} столбца = {matrix[n-1,m-1]}");
}
