using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string token = Console.ReadLine();

        bool hasTenChars = token.Length == 10;

        bool startsWithA = token.StartsWith("A");

        bool hasDigit = token.Any(char.IsDigit);

        if (hasTenChars && startsWithA && hasDigit)
        {
            Console.WriteLine("Acesso permitido");
        }
        else
        {
            Console.WriteLine("Acesso negado");
        }
    }
}