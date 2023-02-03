 /*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int InputExamNumber() // ввод и проверка числа
{
    while (true)
    {
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number))
        {
            return number;
            break;
        }
        Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] SortRowMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            int position = j;
            for (int k = j + 1; k < matr.GetLength(1); k++)
            {
                if (matr[i, k] > matr[i, position]) position = k;
            }
            int value = matr[i, j];
            matr[i, j] = matr[i, position];
            matr[i, position] = value;
        }
    }
    return matr;
}
Console.WriteLine("Введите количество строк");
int m = InputExamNumber();
Console.WriteLine("Введите количество столбцов");
int n = InputExamNumber();
int[,] matrix = new int[m, n];
FillArray(matrix);
Console.WriteLine("Задан массив");
PrintArray(matrix);
Console.WriteLine("Массив после сортировки");
PrintArray(SortRowMatrix(matrix));