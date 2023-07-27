// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void RefundElements(int[,] massive, int rows, int columns)
{
    for(int i = 0; i < massive.GetLength(0); i++)
    {
        for(int j = 0; j < massive.GetLength(1); j++)
        {
            if(rows < massive.GetLength(0) && columns < massive.GetLength(1))
            {
                Console.Write(massive[rows, columns]);
            }
            else
            {
                Console.Write( "-> такого числа в массиве нет");
            }
        }
    } 
}
void Print2DMassive(int[,] massive)                              
{
    for(int i = 0; i < massive.GetLength(0); i++)
    {
        for(int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i,j]}\t");
        }
        Console.WriteLine();
    }
}
int[,] Create2DMassiv(int rows, int columns, int startValue, int finishValue)
{
    int[,] matrix = new int[rows,columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(startValue, finishValue + 1);
        }
    }
    return matrix;
}
int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int rows = GetInput("Введите число строк: ");
int columns = GetInput("Введите число столбцов: ");
int[,] massive = Create2DMassiv(3, 4, 1, 10);
Print2DMassive(massive);
RefundElements(massive, rows, columns);