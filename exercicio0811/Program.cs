using System;

namespace exercicio0811 //onamespace tem que estar o mesmo do program e class
{
    class etapa5
    {
        static void Main(String[] args)
        {
            try
            {
                string almoço = "peixe";
                string sobremesa = "bolo";
                string cafe = "cafe";
                string bebida = "Suco de maça";
                string comidaPredileta = "Macarrão";

                ClassResposta obj = new ClassResposta();
                List<string> resposta = obj.RetornoResposta(bebida, almoço, sobremesa, comidaPredileta);

                Console.WriteLine(resposta);
                Console.WriteLine(comidaPredileta);


                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Houve um erro: " + ex.Message);
            }
        }
    }
}