using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1011
{
    internal class ClassRespostaStatic
    {
        public static List<string> RetornoResposta(string bebida, string almoço, string sobremesa, string respostaComida, out string parametro)
        {
            parametro = "teste";

            List<string> resposta = new List<string>();

            if (almoço == "peixe")
            {
                
                resposta.Add("No almoço tera: " + almoço); 
            }
            else
            {
                
                resposta.Add("Não tem " + almoço + "para o almoço");
            }
            if (almoço == "peixe" && bebida == "Guarana")
            {
                
                resposta.Add("No almoço tera " + almoço + " e de bebida teremos " + bebida);
            }
            else
            {
                
                resposta.Add("Não tem lamento");
            }
            if (bebida == "Suco de maça" || sobremesa == "gelatina")
            {
                
                resposta.Add("Temos um das opções");
            }
            else
            {
               
             
                resposta.Add("Talvez seja hora de fazer dieta");
            }
            string str = respostaComida;

            switch (str)
            {
                case "Feijão":
                    
                    respostaComida = "Comida predileta é feijão";
                    break;
                case "Lasanha":
                    
                    respostaComida = "Comida predileta é lasanha";
                    break;
                case "Macarrão":
                   
                    respostaComida = "Comida predileta é Macarrão";
                    break;
                default:
                    respostaComida = "Não tem lhamento";
                    break;
            }

            return resposta;
        }

        public static void EscreverResposta(string texto)
        {
            Console.WriteLine("A resposta é: " + texto);
        }
    }
}
