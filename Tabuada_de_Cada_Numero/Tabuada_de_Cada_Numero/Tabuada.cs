namespace ConsoleAppTabuada
{
    static public class Tabuada
    {
        static public string tabuada(int numero, int limite) 
        {
            for (int i = 1; i <= limite; i++) 
            {
                int resultado = numero * i;
                Console.WriteLine(resultado);
            }
            return "Tabuada Completa!";
        }
    }
}
