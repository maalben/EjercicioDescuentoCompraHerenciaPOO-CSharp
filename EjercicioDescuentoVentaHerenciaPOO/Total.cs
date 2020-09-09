using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioDescuentoVentaHerenciaPOO
{
    public class Total : Valor
    {
        public double calcularTotal() {
            return (this.getPrecioUnitario() * this.getCantidad());
        }


        public bool aplicarDescuento() {
            if (this.calcularTotal() >= 500000)
            {
                return true;
            }
            else
            {
                return false;
            }   
        }

    }
}
