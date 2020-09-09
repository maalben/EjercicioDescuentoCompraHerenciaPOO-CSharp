using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioDescuentoVentaHerenciaPOO
{
    public class Descuento : Total
    { 
        public double realizarDescuento(double valorDescuento) {
            return ( this.calcularTotal() * (valorDescuento / 100) );
        }



    }
}
