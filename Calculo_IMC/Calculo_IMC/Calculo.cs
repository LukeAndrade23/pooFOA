using Person;

namespace IMC
{
    static public class CalcularIMC
    {
        static public double CalculoIMC(PersonMain person)
        {
            double heightMetros = person.CalculoAlturaMetros();
            return person.Weight / (heightMetros * heightMetros);
        }

        static public string ClassificarIMC(double imc)
        {
            if (imc < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (imc < 24.9)
            {
                return "Peso saudável";
            }
            else if (imc < 29.9)
            {
                return "Sobrepeso";
            }
            else if (imc < 34.9)
            {
                return "Obesidade grau I";
            }
            else if (imc < 39.9)
            {
                return "Obesidade grau II";
            }
            else
            {
                return "Obesidade grau III (mórbida)";
            }
        }

    }
}