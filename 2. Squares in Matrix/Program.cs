﻿
int[] demensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rows = demensions[0];
int cols = demensions[1];

int[,] matrix = new int[rows, cols];

for (int row = 0; row < rows; row++)
{
    char[] chars = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = chars[col];
    }
}


int count = 0;

for (int row = 0; row < rows - 1; row++)
{
    for (int col = 0; col < cols- 1; col++)
    {
        if (matrix[row,col] == matrix[row,col + 1]
            && matrix[row, col] == matrix[row + 1, col + 1]
            && matrix[row, col] == matrix[row + 1, col])
        {
            count++;
        }
    }
}

Console.WriteLine(count);