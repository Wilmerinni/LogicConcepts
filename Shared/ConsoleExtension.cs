namespace Shared;

public static class ConsoleExtension
{
    public static int GetInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);

            if (int.TryParse(Console.ReadLine(), out int value))
            {
                return value;
            }

            Console.WriteLine("Ingrese un número entero válido.");
        }
    }
}