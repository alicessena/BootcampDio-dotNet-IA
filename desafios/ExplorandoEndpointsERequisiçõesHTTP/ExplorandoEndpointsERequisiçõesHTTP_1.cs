using System; 

class Program
{

    static void Main()
    {
        string endpoint = Console.ReadLine();

        if (endpoint == "/clientes")
        {
            Console.WriteLine("Listando clientes...");
        }
        else if (endpoint == "/produtos")
        {
            Console.WriteLine("Exibindo produtos disponiveis...");
        }
        else if (endpoint == "/relatorios")
        {
            Console.WriteLine("Gerando relatorio de desempenho...");
        }
        else
        {
            Console.WriteLine("Endpoint nao reconhecido.");
        }
    }
}