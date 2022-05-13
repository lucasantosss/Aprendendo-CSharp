using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 06 - Atribuição de Váriaveis");

        int idade = 34;
        int idadeRoberto = idade;
        Console.WriteLine(idadeRoberto);

        Console.WriteLine("A idade de Roberto é " + idadeRoberto);

        idade = 25;

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}

