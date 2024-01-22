int[] demensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rows = demensions[0];
int cols = demensions[1];

string word = Console.ReadLine();

char[,] matrix = new char[rows, cols];

int cuurWordIndex = 0;

for (int row = 0; row < rows; row++)
{
    if (row % 2 == 0)
    {
        for (int col = 0; col < cols; col++)
        {
            if (cuurWordIndex == word.Length)
            {
                cuurWordIndex = 0;
            }

            matrix[row, col] = word[cuurWordIndex];
            cuurWordIndex++;
        }

    }
    else
    {
        for (int col = cols - 1; col >= 0; col--)
        {
            if (cuurWordIndex == word.Length)
            {
                cuurWordIndex = 0;
            }

            matrix[row, col] = word[cuurWordIndex];
            cuurWordIndex++;
        }

    }


}


for (int row = 0; row < rows; row++)
{
    for (int col = 0; col < cols; col++)
    {
        Console.Write($"{matrix[row, col]}");
    }
    Console.WriteLine();
}