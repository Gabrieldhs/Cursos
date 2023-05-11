using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
     class Retangulo
    {
        public double L;
        public double A;
        public double Area()
        {
            return L * A;
        }
        public double Perimetro()
        {
            return 2 * (L + A);
        }

        public double Diagonal()
        {
            return Math.Sqrt(L * L + A * A);    
        }
    }
}
