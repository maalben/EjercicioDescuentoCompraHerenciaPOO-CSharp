using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjercicioDescuentoVentaHerenciaPOO
{
    public partial class Form1 : Form
    {
        Descuento descuento = new Descuento();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnprocesarcompra_Click(object sender, EventArgs e)
        {

            if (descuento.aplicarDescuento() == true) {
                MessageBox.Show("Se le aplicará descuento a la compra.");
            } else {
                MessageBox.Show("No tendrás ninguna clase de descuentos.");
            }

            string formaPago;
            double descuentoAplicado;

            if (!rdbefectivo.Checked && !rdbtarjetacredito.Checked && !rdbvaleregalo.Checked) {
                MessageBox.Show("Debes seleccionar una forma de pago");
            } else {

                this.Size = new System.Drawing.Size(676, 575);
                descuento.setCantidad(double.Parse(txtcantidad.Text));

                if (rdbefectivo.Checked == true)
                {
                    formaPago = "EFECTIVO";
                    descuentoAplicado = 10;
                }
                else if (rdbtarjetacredito.Checked == true)
                {
                    formaPago = "TARJETA DE CREDITO";
                    descuentoAplicado = 5;
                }
                else {
                    formaPago = "VALE DE REGALO";
                    descuentoAplicado = 15;
                }

                lblpreciounitarioconiva.Text = "Precio unitario con IVA: " + Convert.ToString((descuento.calcularTotal() + descuento.realizarDescuento(19)) / descuento.getCantidad());
                lbltotalsindescuento.Text = "Total sin descuento: " + Convert.ToString(descuento.calcularTotal());
                lblcantidadimpresorascomprada.Text = "Cantidad de impresoras a comprar: " + Convert.ToString(descuento.getCantidad());
                lblformapago.Text = "Forma de pago: " + formaPago;
                lbldescuentorealizado.Text = "Descuento realizado: " + descuento.realizarDescuento(descuentoAplicado);
                lbltotalpagar.Text = "Total a pagar: " + Convert.ToString((descuento.calcularTotal() - descuento.realizarDescuento(descuentoAplicado)) + descuento.realizarDescuento(19));

            }
        }

        private void btnnuevacompra_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(676, 294);
            txtcantidad.Text = String.Empty;
            rdbefectivo.Checked = false;
            rdbtarjetacredito.Checked = false;
            rdbvaleregalo.Checked = false;
            txtcantidad.Focus();

        }
    }
}
