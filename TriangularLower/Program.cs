using Shared;
using TriangularLower;

Console.WriteLine("*** TRIANGULAR INFERIOR DE UNA MATRIZ ***");

var n = ConsoleExtension.GetInt("Ingrese el tamaño de la matriz: ");

var matrix = new Matrix(n);

matrix.Fill();

Console.WriteLine("\nMatriz:");
matrix.Show();

Console.WriteLine("\nTriangular inferior:");
matrix.ShowLowerTriangle();