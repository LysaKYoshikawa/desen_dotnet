using exercicios1011;
using System;

namespace exercicio1011 //onamespace tem que estar o mesmo do program e class
{
    class etapa5
    {
        static void Main(String[] args)
        {
            ClassResposta.EscreverResposta("teste");
            try
            {
                string almoço = Constantes.almoço;
                string sobremesa = Constantes.sobremesa;
                string bebida = Constantes.bebida;
                string comidaPredileta = Constantes.comidaPredileta;


                string parametro;


                ClassResposta obj = new ClassResposta();
                List<string> resposta = obj.RetornoResposta(bebida, almoço, sobremesa, comidaPredileta, out parametro);


                almoço = Constantes.almoço;
                sobremesa = Constantes.sobremesa;
                bebida = Constantes.bebida;
                comidaPredileta = Constantes.comidaPredileta;

                ClassRespostaStatic.RetornoResposta(bebida, almoço, sobremesa, comidaPredileta, out parametro);
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