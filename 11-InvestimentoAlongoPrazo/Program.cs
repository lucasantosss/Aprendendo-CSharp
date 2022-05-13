using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 11 - Investimento a Longo Prazo");

        double fatordeRendimento = 1.005;
        double investimento = 1000;

        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatordeRendimento;
                Console.WriteLine("No mês: " + mes);
                Console.WriteLine("Depois de 5 anos você terá R$ " + investimento);
            }
            fatordeRendimento += 0.001;
        }

       //onsole.WriteLine("No mês: " + mes);
       //onsole.WriteLine("Depois de 5 anos você terá R$ " + investimento);

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}
