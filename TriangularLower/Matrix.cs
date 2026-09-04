namespace TriangularLower;

public class Matrix
{
    // Fields
    private readonly int[,] _matrix;

    // Constructors
    public Matrix(int n)
    {
        _matrix = new int[n, n];
    }

    // Public Methods
    public void Fill()
    {
        for (int i = 0; i < _matrix.GetLength(0); i++)
        {
            for (int j = 0; j < _matrix.GetLength(1); j++)
            {
                _matrix[i, j] = i + j;
            }
        }
    }

    public void Show()
    {
        for (int i = 0; i < _matrix.GetLength(0); i++)
        {
            for (int j = 0; j < _matrix.GetLength(1); j++)
            {
                Console.Write($"{_matrix[i, j],5}");
            }

            Console.WriteLine();
        }
    }

    public void ShowLowerTriangle()
    {
        for (int i = 0; i < _matrix.GetLength(0); i++)
        {
            for (int j = 0; j < _matrix.GetLength(1); j++)
            {
                if (j <= i)
                {
                    Console.Write($"{_matrix[i, j],5}");
                }
                else
                {
                    Console.Write($"{0,5}");
                }
            }

            Console.WriteLine();
        }
    }
}