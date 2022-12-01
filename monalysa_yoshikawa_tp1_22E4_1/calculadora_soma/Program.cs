namespace Calculadora_Soma
{
    public class Programa_Soma
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;

            Console.WriteLine("Digite um numero: ");
            string? variavelCalculadora = Console.ReadLine();
            bool seConverteu = int.TryParse(variavelCalculadora, out numero1);

            Console.WriteLine("Digite um segundo numero: ");
            string? variavelSoma2 = Console.ReadLine();

            seConverteu = int.TryParse(variavelSoma2, out numero2);

            Console.WriteLine("A soma é: " + (numero1 + numero2));

            Console.ReadKey();
        }
    }
}