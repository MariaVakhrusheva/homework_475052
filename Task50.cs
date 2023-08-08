// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FindElement(int[,] massive, int rowElement, int columnElement)
{
    if (massive.GetLength(0) - 1 < rowElement | massive.GetLength(1) - 1 < columnElement)
{
        Console.Write($"{rowElement}, {columnElement} -> такого числа в массиве нет");
}

else 
{
    Console.Write($"Позиция {rowElement}, {columnElement} -> число {massive[rowElement, columnElement]} есть в данном массиве");
}
}

void Print2DMassive(int[,] massive)
{
    Console.WriteLine();
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Create2DMassive(int rows, int columns, int startValue, int finishValue)
{
    int[,] massiv = new int[rows, columns];
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = new Random().Next(startValue, finishValue + 1);
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
int rowElement = GetInput("Введите cтроку элемента: ");
int columnElement = GetInput("Введите cтолбец элемента: ");
int[,] massive = Create2DMassive(m, n, 0, 20);
Print2DMassive(massive);
FindElement(massive, rowElement, columnElement);
