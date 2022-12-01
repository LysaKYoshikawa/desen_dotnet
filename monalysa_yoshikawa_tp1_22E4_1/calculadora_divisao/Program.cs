namespace Calculadora_Divisao
{
    public class Programa_Divisao
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
            string? validacaoDivNum1 = Console.ReadLine();
            bool seConverteu = int.TryParse(validacaoDivNum1, out numero1);

            Console.WriteLine("Digite um segundo numero: ");
            string? validacaoDivNum2 = Console.ReadLine();

            seConverteu = int.TryParse(validacaoDivNum2, out numero2);

            Console.WriteLine(nome + " O resultado da divisão é: " + (numero1 / numero2) + ".");

            Console.ReadKey();
        }
    }
}