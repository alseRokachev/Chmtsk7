// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int textCheck(string str)
{
    int number;
    string? text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            if (number > 0)
            {
                return number;
            }
        }
        System.Console.WriteLine("Некорректное число");
    }
}

int[] askForSizeOfArray()
{
    int[] array = new int[2];
    array[0] = textCheck("Введите кол-во строк массива: ");
    array[1] = textCheck("Введите кол-во столбцов массива: ");
    return array;
}

int[,] fillArray(int[] arraySize)
{
    Random rand = new Random();
    int[,] matrix = new int[arraySize[0], arraySize[1]];
    for (int i = 0; i < arraySize[0]; i++)
    {
        for (int j = 0; j < arraySize[1]; j++)
        {
            matrix[i, j] = rand.Next(1, 11);
        }
    }
    return matrix;
}

void printArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write(array2D[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void printColAvg(int[,] array2D, int[] arraySize)
{
    for (int j = 0; j < arraySize[1]; j++)
    {
        double avg = 0;
        for (int i = 0; i < arraySize[0]; i++)
        {
            avg += array2D[i, j];
        }
        System.Console.WriteLine($"Среднее арифметическое {j + 1} столбца: {Math.Round((avg / arraySize[0]), 3)}");

    }
}

int[] arraySize = askForSizeOfArray();
int[,] array2D = fillArray(arraySize);
printArray(array2D);
printColAvg(array2D, arraySize);