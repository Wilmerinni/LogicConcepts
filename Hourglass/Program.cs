using Shared;
using Hourglass;

Console.WriteLine("Ingrese orden de la matriz:");

var n = ConsoleExtension.GetInt("");

var matrix = new global::Hourglass.Hourglass(n);

matrix.Fill();

Console.WriteLine("\nMATRIZ COMPLETA");
matrix.Show();

Console.WriteLine("\nRELOJ DE ARENA");
matrix.ShowHourglass();