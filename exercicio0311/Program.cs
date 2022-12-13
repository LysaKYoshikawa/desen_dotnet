using System;

namespace exercicio0311
{
    class switchCase
    {
        static void Main(String[] args)
        {
            try
            {
                string comidaPredileta = "Macarrão";

                switch (comidaPredileta)
                {
                    case "Feijão":
                        Console.WriteLine("Comida predileta é feijão");
                        break;
                    case "Lasanha":
                        Console.WriteLine("Comida predileta é lasanha");
                        break;
                    case "Macarrão":
                        Console.WriteLine("Comida predileta é Macarrão");
                        break;
                    default:
                        break; 
                }

                var i = 20;

                while (i > 0) // --> enquanto verdadeiro irá fazer
                {
                    Console.WriteLine("O valor da variavel i é :" + i);
                    i--; // i = i -1

                    if (i == 0)
                    {
                        Console.WriteLine("Chegou no zero " + i);
                    }
                }

                int contador = 10;

                for(int j=0; j<contador; j++)
                {
                    Console.WriteLine("O valor do j é: " + j);
                }


                int[] array1;
                int[] array2 = new int[3];
                int[] array3 = new int[] {1,2,3,4,5,6};

                List<int> listNumero = new List<int>();
                listNumero.Add(1);
                listNumero.Add(2);
                listNumero.Add(3);
                listNumero.Add(4);
                listNumero.Add(5);

                foreach(int num in listNumero)
                {
                    Console.WriteLine("O valor do listnumero(num) é: " + num);
                }


                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Houve um erro: "+ ex.Message);
            }
        }
    }
}