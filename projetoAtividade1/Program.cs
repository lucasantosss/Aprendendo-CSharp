using System;

class Programa
{
    static void Main(string[] args)
    {
        int n1, n2, n3, n4, res;

        Console.Write("Digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        n2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        n3 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        n4 = int.Parse(Console.ReadLine());

        res = n1 + n2 + n3 + n4;
        int media = res / 4;
        Console.WriteLine("Sua média é: " + media);

        if (media >= 6)
        {
            Console.WriteLine("Parabéns, você passou!");
        }
        else if (media == 5)
        {
            Console.WriteLine("Você está de recuperação!");
        }
        else
        {
            Console.WriteLine("Você foi reprovado, mais sorte na próxima");
        }

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}
