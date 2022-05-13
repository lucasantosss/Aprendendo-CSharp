using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12 - Encadeando For");

        //com break
        for(int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
        {
            for(int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
            {
                Console.Write("*");
                if (contadorColuna >= contadorLinha)
                    break;
            }
            Console.WriteLine();
        }

        //sem break
        for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
        {
            for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
            {
                Console.Write("*");
                if (contadorColuna >= contadorLinha)
                    break;
            }
            Console.WriteLine();
        }
        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}
