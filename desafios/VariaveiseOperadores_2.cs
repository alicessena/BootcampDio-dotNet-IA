using System;

class Program
{
    static void Main(string[] args)
    {
        string entrada = Console.ReadLine();
        
        string[] partes = entrada.Split(' ');

        string quantidade = partes[0];

        Console.WriteLine(quantidade + " interacoes");
    }
}