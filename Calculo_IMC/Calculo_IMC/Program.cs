using System;
using IMC;
using Person;

namespace CalculoIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de IMC");

            Console.Write("Digite o seu peso em kg: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a sua altura em cm: ");
            double heightCm = Convert.ToDouble(Console.ReadLine());


            double heightMetros = heightCm / 100;


            PersonMain pessoa = new PersonMain(weight, heightCm);

            double imc = CalcularIMC.CalculoIMC(pessoa);


            string classification = CalcularIMC.ClassificarIMC(imc);

            Console.WriteLine($"Seu IMC é: " + imc);
            Console.WriteLine($"Classificação: " + classification);
        }
    }
}
