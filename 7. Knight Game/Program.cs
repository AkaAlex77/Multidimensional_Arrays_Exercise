int size = int.Parse(Console.ReadLine());

if (size < 3)
{
    Console.WriteLine(0);

    return;
}

char[,] matrix = new char[size, size];

for (int row = 0; row < size; row++)
{
    string chars = Console.ReadLine();
    for (int col = 0; col < size; col++)
    {
        matrix[row, col] = chars[col];
    }
}

int knnightRemoved = 0;

while (true)
{
    int cuountMostAttacing = 0;
    int rowMostAtt = 0;
    int colMostAtt = 0;

    for (int row = 0; row < size; row++)
    {
        for (int col = 0; col < size; col++)
        {
            if (matrix[row,col] == 'K')
            {
                int attacedKnigth = CountAttackedKnights(row, col, size, matrix);

                if (cuountMostAttacing < attacedKnigth)
                {
                    cuountMostAttacing = attacedKnigth;
                    rowMostAtt = row;
                    colMostAtt = col;
                }
            }
        }
    }

    if (cuountMostAttacing == 0)
    {
        break;
    }
    else
    {
        matrix[rowMostAtt, colMostAtt] = '0';
        knnightRemoved++;
    }

}

Console.WriteLine(knnightRemoved);


static int CountAttackedKnights(int row, int col, int size, char[,] matrix)
{
    int attackedKnight = 0;

    if (IsCellValid(row - 1, col-2, size))
    {
        if (matrix[row - 1, col - 2] == 'K')
        {
            attackedKnight++;
        }
    }

    if (IsCellValid(row + 1, col - 2, size))
    {
        if (matrix[row + 1, col - 2] == 'K')
        {
            attackedKnight++;
        }
    }

    if (IsCellValid(row - 1, col + 2, size))
    {
        if (matrix[row - 1, col + 2] == 'K')
        {
            attackedKnight++;
        }
    }

    if (IsCellValid(row + 1, col + 2, size))
    {
        if (matrix[row + 1, col + 2] == 'K')
        {
            attackedKnight++;
        }
    }

    if (IsCellValid(row - 2, col - 1, size))
    {
        if (matrix[row - 2, col - 1] == 'K')
        {
            attackedKnight++;
        }
    }

    if (IsCellValid(row - 2, col + 1, size))
    {
        if (matrix[row - 2, col + 1] == 'K')
        {
            attackedKnight++;
        }
    }

    if (IsCellValid(row + 2, col - 1, size))
    {
        if (matrix[row + 2, col - 1] == 'K')
        {
            attackedKnight++;
        }
    }

    if (IsCellValid(row + 2, col + 1, size))
    {
        if (matrix[row + 2, col + 1] == 'K')
        {
            attackedKnight++;
        }
    }



    return attackedKnight;
}

static bool IsCellValid(int row, int col, int size)
{
    return row >= 0
    && row < size
    && col >= 0
    && col < size;
}
