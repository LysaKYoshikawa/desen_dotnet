using System;

namespace BoxingUboxingTeste
{
    class program
    {
        static void Main(string[] args)
        {
            try
            {
                int i = 777; //tipo primitivo / tipo de valor
                object o = i; //oxing i->o (estou jogando o i para dentro "o" ou seja int para objecto)
                int j = (int)o; //unboxing de "o" para "j" 
                Console.WriteLine("Realizado com sucesso");

                Console.WriteLine("Data atual" + DateTime.Now);
                Console.WriteLine("Data atual minimo " + DateTime.MinValue); //tera uma data minima e valor minimo
                Console.WriteLine("Data atual minimo " + DateTime.MaxValue); //tera o valor maximo

                DateTime data;

                DateTime finalAno = new DateTime(2022, 12, 31);

                Console.WriteLine("Faltam :" + finalAno.Subtract(DateTime.Now) + "dias para acabar o ano!!!");

                throw new Exception("Lançado uma exception"); //erro critico, lançado exception
            }
            catch(Exception ex)
            {
                Console.WriteLine("Aconteceu um erro na aplicação: " + ex.Message);
            }
            

            Console.ReadKey();
        }
    }
}