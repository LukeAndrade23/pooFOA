using System;
using ConsoleAppTabuada;

namespace TabuadaGenerator 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Bem-vindo ao Gerador de Tabuadas!");

            Console.WriteLine("Digite um número para gerar a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número máximo da tabuada: ");
            int limite = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabuada do {numero}:");

            string resultado = Tabuada.tabuada(numero, limite);

            Console.WriteLine(resultado);
        }
    }
}