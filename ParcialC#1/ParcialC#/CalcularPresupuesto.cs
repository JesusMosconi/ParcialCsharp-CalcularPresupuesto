using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialC_
{
    public class CalcularPresupuesto
    {
        public int ancho;
        public int alto;
        public int Valor;
        public int total; 


          public int CalcularPresupuestos(int ancho, int alto, int Valor) {

             total = (ancho + alto) * Valor;
            return total;
            

        }

}
}
