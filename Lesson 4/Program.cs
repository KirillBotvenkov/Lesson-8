/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
*/

using System;
using System.Linq;

int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
//int m = int.Parse(Console.ReadLine());
//int t = int.Parse(Console.ReadLine());
int[,,] baseArray = new int[size[0], size[1], size[2]];

for (int i = 0; i < baseArray.GetLength(0); i++)
{
    for (int j = 0; j < baseArray.GetLength(1); j++)
    {
        int k = 0;
        while (k < baseArray.GetLength(2))
        {
            var rnd = new Random().Next(size[0] * size[1] * size[2] + 3);
            if (!FindElement(rnd, baseArray))
            {
                baseArray[i, j, k] = rnd;
                k++;
            }
        }
    }
}

PrintArray(baseArray);



void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ");
            }
            Console.WriteLine();
        }
    }

}



bool FindElement(int element, int[,,] array)
{
    bool res = false;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == element) return true;
            }
        }
    }
    return res;
}