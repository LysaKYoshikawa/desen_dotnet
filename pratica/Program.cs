using System;

namespace praticavalidacao
{
    class validacao
    {
        static void Main(String[] args)
        {
            SortedDictionary<string, int> dicionario = new SortedDictionary<string, int>();

            dicionario.Add("Gyoza", 2);
            dicionario.Add("Lamen", 5);
            dicionario.Add("goran", 6);

            if (dicionario.ContainsKey("Gyoza"))
            {
                Console.WriteLine("Humm...Eu gosto");
            }
            int v;
            if (dicionario.TryGetValue("goran", out v))
            {
                Console.WriteLine(v);
            }
        }
    }
}