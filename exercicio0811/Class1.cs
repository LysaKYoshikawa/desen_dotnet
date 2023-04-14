using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio0811
{
    internal class ClassResposta
    {
        public List<string> RetornoResposta(string bebida, string almoço, string sobremesa, string respostaComida)
        {   
            List<string> resposta = new List<string>();

            if (almoço == "peixe")
            {
                //Console.WriteLine("No almoço tera: " + almoço);
                resposta.Add("No almoço tera: " + almoço); 
            }
            else
            {
                //Console.WriteLine("Não tem " + almoço + "para o almoço");
                resposta.Add("Não tem " + almoço + "para o almoço");
            }
            if (almoço == "peixe" && bebida == "Guarana")
            {
                //Console.WriteLine("No almoço tera " + almoço + " e de bebida teremos " + bebida);
                resposta.Add("No almoço tera " + almoço + " e de bebida teremos " + bebida);
            }
            else
            {
                //Console.WriteLine("Não tem lamento");
                resposta.Add("Não tem lamento");
            }
            if (bebida == "Suco de maça" || sobremesa == "gelatina")
            {
                // Console.WriteLine("Temos um das opções");
                resposta.Add("Temos um das opções");
            }
            else
            {
               // Console.WriteLine("Talvez seja hora de fazer dieta");
             
                resposta.Add("Talvez seja hora de fazer dieta");
            }
            string str = respostaComida;

            switch (str)
            {
                case "Feijão":
                    //Console.WriteLine("Comida predileta é feijão");
                    respostaComida = "Comida predileta é feijão";
                    break;
                case "Lasanha":
                    //Console.WriteLine("Comida predileta é lasanha");
                    respostaComida = "Comida predileta é lasanha";
                    break;
                case "Macarrão":
                   // Console.WriteLine("Comida predileta é Macarrão");
                    respostaComida = "Comida predileta é Macarrão";
                    break;
                default:
                    respostaComida = "Não tem lhamento";
                    break;
            }

            return resposta;
        }
    }
}
