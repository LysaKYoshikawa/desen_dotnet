using System;
using exercicios_aula;

namespace LysaEtapa3
{
    public class program
    {
        static void Main(string[] args)
        {
            string nome = string.Empty;

            nome = "adsaddNVERNO";

            int quantidade = 777888;


            Console.WriteLine("Tamanho da variavel nome:" + nome.Length);

            Console.WriteLine("Deixar Minusculo: " + nome.ToLower());

            Console.WriteLine("Começar apartir da 3 letra que é: " + nome.Substring(3));

            Console.WriteLine("Conteudo da variavel Quantidade :" + quantidade);

            Console.WriteLine("Tamanho Máximo da quantidade é: " + int.MaxValue);

            int.TryParse("teste", out quantidade);

            Funcoes obj = new Funcoes();

            int teste = obj.Soma(5, 5);

            Console.WriteLine(teste);

            int total;
            obj.Soma(4, 2, out total);
            Console.WriteLine(total);

            Console.ReadKey();
        }
    }
}