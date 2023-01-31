using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanciaP_CS
{
    class Distancia : Puntos
    {
        public Distancia(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }

        public double Calcular()
        {
            double d;
            d = ((Math.Pow(x2 - x1, 2)) + (Math.Pow(y2 - y1, 2)));
            d = (Math.Sqrt(d));
            return d;
        }
    }
}
