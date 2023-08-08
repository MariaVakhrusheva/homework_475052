// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Print2DMassive(double[,] massive)
{
    Console.WriteLine();
    Console.WriteLine($"m = {massive.GetLength(0)}, n = {massive.GetLength(1)}.");
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]}\t");
        }
        Console.WriteLine();
    }
}

double[,] Create2DMassive(int rows, int columns, int startValue, int finishValue)
{
    double[,] massiv = new double[rows, columns];
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = Math.Round(startValue + new Random().NextDouble() * (finishValue - startValue), 1);
        }
    }
    return massiv;
}

int GetInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите количество строк массива: ");
int n = GetInput("Введите количество столбцов массива: ");
double[,] massive = Create2DMassive(m, n, -10, 10);
Print2DMassive(massive);
