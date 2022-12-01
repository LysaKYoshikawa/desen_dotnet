using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_aula
{
    public class Funcoes
    {
        public int Soma(int a, int b)
        {
            return a + b;
        }

        public void Soma(int a, int b, out int c)
        {
            c = a + b;
        }
    }
}
