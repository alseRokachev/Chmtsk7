// Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

int textCheckForNumb(string str) {
      int number;
    string? text;
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            if (number > 0 && number < 11)
            {
                return number;
            }
        }
        System.Console.WriteLine("Некорректное число");
    }
}

int[,] fillArray(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
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

void numbCheck(int element, int[,] array2D)
{
    int counter = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (element == array2D[i, j])
            {
                System.Console.WriteLine($"Да, есть такой элемент. Его индекс: [{i},{j}]");
                counter++;
            }
        }
    }
    if (counter == 0)
    {
        System.Console.WriteLine("Такого числа нет");
    }
}


int rows = textCheck("Введите кол-во строк массива: ");
int cols = textCheck("Введите кол-во столбцов массива: ");
int[,] array2D = fillArray(rows, cols);
int element = textCheckForNumb("Введите число от 1 до 10: ");
printArray(array2D);
numbCheck(element, array2D);