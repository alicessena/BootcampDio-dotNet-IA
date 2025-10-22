using System; 

class Programa 
{
    static void Main() 
    {
        string entrada = Console.ReadLine(); 

        if (entrada == "basico")
        {
            Console.WriteLine("Recomendado: plano basico");
        }
        else if (entrada == "intermediario")
        {
            Console.WriteLine("Recomendado: plano intermediario");
        }
        else if (entrada == "avancado" || entrada == "premium")
        {
            Console.WriteLine("Recomendado: plano avancado"); 
        }
    }
}