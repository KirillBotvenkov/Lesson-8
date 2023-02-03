 //Напишите программу, которая заполнит спирально массив 4 на 4

 Console.Write("Введите размерность массива, который будем заполнять: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;
while (temp <= n * n)
{
    array[i,j] = temp;
    if (i <= j + 1 && i + j < n - 1)
        ++j;
    else if (i < j && i + j >= n - 1)
        ++i;
    else if (i >= j && i + j > n - 1)
        --j;
    else
        --i;
    ++temp;
}
for (int c = 0; c < array.GetLength(0); c++)
{
    for (int d = 0; d < array.GetLength(1); d++)
    {
        Console.Write( $"{array[c,d]:d3} ");
    }
    Console.WriteLine();
}
Console.WriteLine();