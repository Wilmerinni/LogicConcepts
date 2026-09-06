namespace Hourglass;

public class Hourglass(int n)
{
    // Fields
    private readonly int[,] _matrix = new int[n, n];

    // Public Methods
    public void Fill()
    {
        for (int i = 0; i < _matrix.GetLength(0); i++)
        {
            for (int j = 0; j < _matrix.GetLength(1); j++)
            {
                _matrix[i, j] = 2 * i + j;
            }
        }
    }

    public void Show()
    {
        for (int i = 0; i < _matrix.GetLength(0); i++)
        {
            for (int j = 0; j < _matrix.GetLength(1); j++)
            {
                Console.Write($"{_matrix[i, j],3}");
            }

            Console.WriteLine();
        }
    }

    public void ShowHourglass()
    {
        int n = _matrix.GetLength(0);
        int middle = n / 2;

        for (int i = 0; i < n; i++)
        {
            int start;
            int end;

            if (i <= middle)
            {
                start = i;
                end = n - 1 - i;
            }
            else
            {
                start = n - 1 - i;
                end = i;
            }

            for (int j = 0; j < n; j++)
            {
                if (j >= start && j <= end)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write($"{_matrix[i, j],3}");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write("   ");
                }
            }

            Console.WriteLine();
        }
    }
}