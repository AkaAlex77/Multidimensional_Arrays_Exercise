
int[] demensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rows = demensions[0];
int cols = demensions[1];

string[,] matrix = new string[rows, cols];

for (int row = 0; row < rows; row++)
{
    string[] stings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = stings[col];
    }
}


string input;
while ((input = Console.ReadLine().ToLower()) != "end")
{
    string[] tokens = input.Split().ToArray();

    if (IsvalidCommand(rows,cols, tokens))
    {
        string tempVAlue = matrix[int.Parse(tokens[1]), int.Parse(tokens[2])];
        matrix[int.Parse(tokens[1]), int.Parse(tokens[2])] = matrix[int.Parse(tokens[3]), int.Parse(tokens[4])];
        matrix[int.Parse(tokens[3]), int.Parse(tokens[4])] = tempVAlue;
        PrintMatrix(matrix);
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
}

static bool IsvalidCommand(int rows, int cols, string[] tokens)
{
    bool isValid = tokens[0] == "swap" && tokens.Length == 5
        && int.Parse(tokens[1]) >= 0 && int.Parse(tokens[1]) < rows
        && int.Parse(tokens[2]) >= 0 && int.Parse(tokens[2]) < cols
        && int.Parse(tokens[3]) >= 0 && int.Parse(tokens[3]) < rows
        && int.Parse(tokens[4]) >= 0 && int.Parse(tokens[4]) < cols;

return isValid;
}

static void PrintMatrix(string[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write($"{matrix[row, col]} ");
        }
        Console.WriteLine();
    }

}