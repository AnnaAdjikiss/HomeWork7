// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
void Array(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((new Random().NextDouble()-0.5) * 100, 3);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }

}
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Array(rows, columns);
*/

// Задача 2. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
void SearchMatrix(int[,] array, int i, int j)
{
    if (i < array.GetLength(0) && j < array.GetLength(1))
        Console.WriteLine("Такой элемент есть! вот он: " + array[i, j]);
    else Console.WriteLine("Такого элемента нет");
}

Console.WriteLine("У нас есть двумерный массив, давайте поиграем в игру :)");
Console.WriteLine("Вы вводите два целых положительных числа, а мы поищем, есть ли такой элемент");
Console.WriteLine("Введите первое число (индекс по горизонтали): ");
int valueI = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число (индекс по вертикали): ");
int valueJ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вот наш массив:");
int rows = new Random().Next(2, 6);
int columns = new Random().Next(2, 6);
int[,] matrix = new int[rows, columns];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-100, 100);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
SearchMatrix(matrix, valueI, valueJ);
*/


// Задача 3. 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] NewMatrix(int n, int m)
{
    int[,] martix = new int[n, m];
    for (int i = 0; i < martix.GetLength(0); i++)
    {
        for (int j = 0; j < martix.GetLength(1); j++)
        {
            martix[i, j] = new Random().Next(0, 10);
            Console.Write(martix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return martix;
}
void ColumnsAverage(int[,] array)
{
    double[] summcolumn = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summcolumn[j] = summcolumn[j] + array[i,j];
        }
    }
    Console.Write("Среднее арифмитическое по столбцам: ");
    for (int i = 0; i < summcolumn.Length; i++)
    {
        Console.Write((Math.Round((summcolumn[i]/array.GetLength(0)), 1)) + "   ");
    }
}
int rows = new Random().Next(2, 6);
int columns = new Random().Next(2, 6);
Console.WriteLine("Задан массив:");
ColumnsAverage(NewMatrix(rows, columns));