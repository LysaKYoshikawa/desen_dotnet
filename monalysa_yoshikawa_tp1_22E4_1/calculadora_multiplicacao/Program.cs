namespace Calculadora_Multiplicacao
{
    public class Programa_Multi
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            string? nome;

            Console.WriteLine("Digite um nome de usuario: ");
            nome = Console.ReadLine();
            Console.WriteLine("Olá, " + nome);

            Console.WriteLine("Digite um numero: ");
            string? validacaoMultiNum1 = Console.ReadLine();
            bool seConverteu = int.TryParse(validacaoMultiNum1, out numero1);

            Console.WriteLine("Digite um segundo numero: ");
            string? validacaoMultiNum2 = Console.ReadLine();

            seConverteu = int.TryParse(validacaoMultiNum2, out numero2);

            Console.WriteLine(nome + " O resultado da multiplicação é: " + (numero1 * numero2) + ".");

            Console.ReadKey();
        }
    }
}