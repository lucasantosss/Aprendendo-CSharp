using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atividade 03 - Multiplos de 3");

        for(int numero = 3; numero <= 100; numero += 3)
        {
            Console.WriteLine(numero);
        }

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}
