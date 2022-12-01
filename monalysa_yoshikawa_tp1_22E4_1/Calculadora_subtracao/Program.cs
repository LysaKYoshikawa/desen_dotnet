namespace Calculadora_Subtracao
{
    public class Programa_Sub
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
            string? validacaoSubNum1 = Console.ReadLine();
            bool seConverteu = int.TryParse(validacaoSubNum1, out numero1);

            Console.WriteLine("Digite um segundo numero: ");
            string? validacaoSubNum2 = Console.ReadLine();

            seConverteu = int.TryParse(validacaoSubNum2, out numero2);

            Console.WriteLine(nome + " O resultado da subtração é: " + (numero1 - numero2) + ".");

            Console.ReadKey();
        }
    }
}