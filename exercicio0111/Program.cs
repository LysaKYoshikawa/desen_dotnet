using System;

namespace interacoes
{
    class exercicio
    {
        static void Main(String[] args)
        {
            try
            {
                int numero = 5656;
                string nome = "Monalysavvv";

                if(numero == 565)
                {
                    Console.WriteLine("É igual ao valor " + numero);
                }
                else
                {
                    Console.WriteLine("Não É igual ao valor " + numero);
                }
                if(numero==5656 && nome =="Monalysa")
                {
                    Console.WriteLine("O numero é: " + numero + " e o nome é igual a " + nome);
                }
                else
                {
                    Console.WriteLine("Não passou na validação");
                }
                Console.ReadKey();

            }
            catch(Exception)
            {

            }
        }
    }
}