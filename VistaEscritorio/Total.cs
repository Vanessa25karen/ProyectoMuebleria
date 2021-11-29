using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistaEscritorio
{
    class Total
    {

        public int Totales(int PrecioSillon, int CantSillon)
        {
            int Precio = PrecioSillon;
            int Cantidad = CantSillon;
            int T = Precio * Cantidad;
            return T;
        }

    }
}
