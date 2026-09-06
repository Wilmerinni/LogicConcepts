using Shared;
using Hourglass;

Console.WriteLine("Ingrese orden de la matriz:");

var n = ConsoleExtension.GetInt("");

var hourglass = new Hourglass.Hourglass(n);

hourglass.Fill();

Console.WriteLine("\nMATRIZ COMPLETA");
hourglass.Show();

Console.WriteLine("\nRELOJ DE ARENA");
hourglass.ShowHourglass();