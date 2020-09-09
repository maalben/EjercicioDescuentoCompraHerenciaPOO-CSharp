using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjercicioDescuentoVentaHerenciaPOO
{
    public class Valor
    {
        private double cantidad;
        private double precioUnitario;

        public Valor() {
            this.precioUnitario = 80000;
        }

        public double getPrecioUnitario() {
            return this.precioUnitario;
        }

        public void setCantidad(double valor) {
            this.cantidad = valor;
        }

        public double getCantidad() {
            return this.cantidad;
        }
    }
}
