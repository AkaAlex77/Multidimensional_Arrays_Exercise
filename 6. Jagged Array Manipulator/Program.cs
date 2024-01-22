int rows = int.Parse(Console.ReadLine());

int[] [] jaggedArray = new int[rows][];

for (int row = 0; row < rows; row++)
{
    int[] cols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    jaggedArray[row] = cols;
}

for (int row = 0; row < rows - 1; row++)
{
    if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
    {
        for (int col = 0; col < jaggedArray[row].Length; col++)
        {
            jaggedArray[row][col] *= 2;
            jaggedArray[row + 1][col] *= 2;

        }
    }
    else
    {
        for (int col = 0; col < jaggedArray[row].Length; col++)
        {
            jaggedArray[row][col] /= 2;

        }
        for (int col = 0; col < jaggedArray[row + 1].Length; col++)
        {
            jaggedArray[row + 1][col] /= 2;

        }
    }
}

string input;

while ((input = Console.ReadLine()) != "End")
{
    string[] command = input.Split();

    string action = command[0];
    int row =  int.Parse(command[1]);
    int col = int.Parse(command[2]);
    int value = int.Parse(command[3]);

    if (ValidCoordinaated(row, col, jaggedArray))
    {
        if (action == "Add")
        {
            jaggedArray[row][col] += value;
        }
        else
        {
            jaggedArray[row][col] -= value;
        }
    }

}

for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < jaggedArray[row].Length; col++)
    {
        Console.Write($"{jaggedArray[row][col]} ");
    }
    Console.WriteLine();
}


static bool ValidCoordinaated(int row, int col, int[][] jaggedArray)
{
    return row>=0
        && row < jaggedArray.Length
        && col >= 0
        && col < jaggedArray[row].Length;
}