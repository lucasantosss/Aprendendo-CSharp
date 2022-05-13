using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 05 - Caracteres e Textos");

        char letra;

        letra = (char)76;
        Console.WriteLine(letra);

        letra = (char)85;
        Console.WriteLine(letra);

        letra = (char)67;
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)83;
        Console.WriteLine(letra);

        letra = (char)76;
        Console.Write(letra);

        letra = (char)85;
        Console.Write(letra);

        letra = (char)67;
        Console.Write(letra);

        letra = (char)65;
        Console.Write(letra);

        letra = (char)83;
        Console.WriteLine(letra);

        string primeiraFrase = "SENAI - Cursos de Tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' ';

        string cursos = @"Cursos disponíveis: - 
C  
C++ 
HTML 
CSharp";
        Console.WriteLine(cursos);

        Console.WriteLine("Pressione ENTER para encerrar");
        Console.ReadLine();
    }
}

