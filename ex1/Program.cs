// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

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

double[,] fillArray(int[] arraySize)
{
    double[,] arrayChanged = new double[arraySize[0], arraySize[1]];
    Random rand = new Random();
    for (int i = 0; i < arraySize[0]; i++)
    {
        for (int j = 0; j < arraySize[1]; j++)
        {
            arrayChanged[i, j] = Math.Round(rand.Next(-50, 50) + rand.NextDouble(), 3);
        }
    }
    return arrayChanged;
}

void printArray(double[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write(array2D[i, j] + "\t" + "\t");
        }
        System.Console.WriteLine();
        System.Console.WriteLine();
    }
}

int[] arraySize = askForSizeOfArray();
double[,] array2D = fillArray(arraySize);
printArray(array2D);