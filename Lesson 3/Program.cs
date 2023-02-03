 /*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int [,] CreateRandomMatrix (int row, int column, int min, int max)
{
    var rnd = new Random();
    int [,] newMatrix = new int [row,column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            newMatrix[i,j] = rnd.Next(min, max+1);
        }
    }
    return newMatrix;
}

void PrintArray (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}"+"\t");
        }
        Console.WriteLine();
    }
}

void MultiplyIfPossible(int [,] matrixA, int [,] matrixB)
{
    if (matrixA.GetLength(1)!=matrixB.GetLength(0))
    {
        Console.WriteLine();
    }
    else
    {
        int[,] multiplicative = MatrixMultiplication(matrixA, matrixB);
        PrintArray(multiplicative);
    }
}
int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] multiplicative = new int [matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < multiplicative.GetLength(0); i++)
    {
        for (int j = 0; j < multiplicative.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1);k++)
            {
                multiplicative[i,j] = multiplicative[i,j] + matrixA[i,k]* matrixB[k,j];
            }
        }
    }
    return multiplicative;
}

void Solve()
{
    int n = 2;
    int m = 3;
    int o = 3;
    int p = 4;

    int min = 0;
    int max = 10;
    int[,] matrixA = CreateRandomMatrix(n,m,min,max);
    int[,] matrixB = CreateRandomMatrix(o,p,min,max);
    PrintArray(matrixA);
    Console.WriteLine();
    PrintArray(matrixB);
    Console.WriteLine();
    MultiplyIfPossible(matrixA,matrixB);
    }
    Solve();