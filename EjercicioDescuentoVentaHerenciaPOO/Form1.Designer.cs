namespace EjercicioDescuentoVentaHerenciaPOO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbefectivo = new System.Windows.Forms.RadioButton();
            this.rdbtarjetacredito = new System.Windows.Forms.RadioButton();
            this.rdbvaleregalo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.btnprocesarcompra = new System.Windows.Forms.Button();
            this.lblcantidadimpresorascomprada = new System.Windows.Forms.Label();
            this.lblpreciounitarioconiva = new System.Windows.Forms.Label();
            this.lbltotalsindescuento = new System.Windows.Forms.Label();
            this.lblformapago = new System.Windows.Forms.Label();
            this.lbldescuentorealizado = new System.Windows.Forms.Label();
            this.lbltotalpagar = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnnuevacompra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "S.I PRINTFACIL S.A de C.V";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbvaleregalo);
            this.groupBox1.Controls.Add(this.rdbtarjetacredito);
            this.groupBox1.Controls.Add(this.rdbefectivo);
            this.groupBox1.Location = new System.Drawing.Point(475, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formas de Pago";
            // 
            // rdbefectivo
            // 
            this.rdbefectivo.AutoSize = true;
            this.rdbefectivo.Location = new System.Drawing.Point(28, 38);
            this.rdbefectivo.Name = "rdbefectivo";
            this.rdbefectivo.Size = new System.Drawing.Size(64, 17);
            this.rdbefectivo.TabIndex = 0;
            this.rdbefectivo.TabStop = true;
            this.rdbefectivo.Text = "Efectivo";
            this.rdbefectivo.UseVisualStyleBackColor = true;
            // 
            // rdbtarjetacredito
            // 
            this.rdbtarjetacredito.AutoSize = true;
            this.rdbtarjetacredito.Location = new System.Drawing.Point(28, 74);
            this.rdbtarjetacredito.Name = "rdbtarjetacredito";
            this.rdbtarjetacredito.Size = new System.Drawing.Size(108, 17);
            this.rdbtarjetacredito.TabIndex = 1;
            this.rdbtarjetacredito.TabStop = true;
            this.rdbtarjetacredito.Text = "Tarjeta de crédito";
            this.rdbtarjetacredito.UseVisualStyleBackColor = true;
            // 
            // rdbvaleregalo
            // 
            this.rdbvaleregalo.AutoSize = true;
            this.rdbvaleregalo.Location = new System.Drawing.Point(28, 111);
            this.rdbvaleregalo.Name = "rdbvaleregalo";
            this.rdbvaleregalo.Size = new System.Drawing.Size(93, 17);
            this.rdbvaleregalo.TabIndex = 2;
            this.rdbvaleregalo.TabStop = true;
            this.rdbvaleregalo.Text = "Vale de regalo";
            this.rdbvaleregalo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(27, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de impresoras a comprar:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.txtcantidad.Location = new System.Drawing.Point(33, 181);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(255, 68);
            this.txtcantidad.TabIndex = 3;
            // 
            // btnprocesarcompra
            // 
            this.btnprocesarcompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnprocesarcompra.Location = new System.Drawing.Point(294, 196);
            this.btnprocesarcompra.Name = "btnprocesarcompra";
            this.btnprocesarcompra.Size = new System.Drawing.Size(170, 38);
            this.btnprocesarcompra.TabIndex = 4;
            this.btnprocesarcompra.Text = "Procesar compra";
            this.btnprocesarcompra.UseVisualStyleBackColor = true;
            this.btnprocesarcompra.Click += new System.EventHandler(this.btnprocesarcompra_Click);
            // 
            // lblcantidadimpresorascomprada
            // 
            this.lblcantidadimpresorascomprada.AutoSize = true;
            this.lblcantidadimpresorascomprada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblcantidadimpresorascomprada.Location = new System.Drawing.Point(35, 27);
            this.lblcantidadimpresorascomprada.Name = "lblcantidadimpresorascomprada";
            this.lblcantidadimpresorascomprada.Size = new System.Drawing.Size(264, 25);
            this.lblcantidadimpresorascomprada.TabIndex = 5;
            this.lblcantidadimpresorascomprada.Text = "CantidadImpresorasComprar";
            // 
            // lblpreciounitarioconiva
            // 
            this.lblpreciounitarioconiva.AutoSize = true;
            this.lblpreciounitarioconiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblpreciounitarioconiva.Location = new System.Drawing.Point(35, 102);
            this.lblpreciounitarioconiva.Name = "lblpreciounitarioconiva";
            this.lblpreciounitarioconiva.Size = new System.Drawing.Size(196, 25);
            this.lblpreciounitarioconiva.TabIndex = 6;
            this.lblpreciounitarioconiva.Text = "PrecioUnitarioConIva";
            // 
            // lbltotalsindescuento
            // 
            this.lbltotalsindescuento.AutoSize = true;
            this.lbltotalsindescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbltotalsindescuento.Location = new System.Drawing.Point(35, 64);
            this.lbltotalsindescuento.Name = "lbltotalsindescuento";
            this.lbltotalsindescuento.Size = new System.Drawing.Size(179, 25);
            this.lbltotalsindescuento.TabIndex = 7;
            this.lbltotalsindescuento.Text = "TotalSinDescuento";
            // 
            // lblformapago
            // 
            this.lblformapago.AutoSize = true;
            this.lblformapago.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblformapago.Location = new System.Drawing.Point(35, 141);
            this.lblformapago.Name = "lblformapago";
            this.lblformapago.Size = new System.Drawing.Size(139, 25);
            this.lblformapago.TabIndex = 8;
            this.lblformapago.Text = "FormaDePago";
            // 
            // lbldescuentorealizado
            // 
            this.lbldescuentorealizado.AutoSize = true;
            this.lbldescuentorealizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbldescuentorealizado.Location = new System.Drawing.Point(35, 178);
            this.lbldescuentorealizado.Name = "lbldescuentorealizado";
            this.lbldescuentorealizado.Size = new System.Drawing.Size(192, 25);
            this.lbldescuentorealizado.TabIndex = 9;
            this.lbldescuentorealizado.Text = "DescuentoRealizado";
            // 
            // lbltotalpagar
            // 
            this.lbltotalpagar.AutoSize = true;
            this.lbltotalpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbltotalpagar.Location = new System.Drawing.Point(39, 215);
            this.lbltotalpagar.Name = "lbltotalpagar";
            this.lbltotalpagar.Size = new System.Drawing.Size(122, 25);
            this.lbltotalpagar.TabIndex = 10;
            this.lbltotalpagar.Text = "TotalAPagar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblcantidadimpresorascomprada);
            this.groupBox2.Controls.Add(this.lbltotalpagar);
            this.groupBox2.Controls.Add(this.lblpreciounitarioconiva);
            this.groupBox2.Controls.Add(this.lbldescuentorealizado);
            this.groupBox2.Controls.Add(this.lbltotalsindescuento);
            this.groupBox2.Controls.Add(this.lblformapago);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 252);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de la venta";
            // 
            // btnnuevacompra
            // 
            this.btnnuevacompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnnuevacompra.Location = new System.Drawing.Point(457, 366);
            this.btnnuevacompra.Name = "btnnuevacompra";
            this.btnnuevacompra.Size = new System.Drawing.Size(154, 38);
            this.btnnuevacompra.TabIndex = 12;
            this.btnnuevacompra.Text = "Nueva compra";
            this.btnnuevacompra.UseVisualStyleBackColor = true;
            this.btnnuevacompra.Click += new System.EventHandler(this.btnnuevacompra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 255);
            this.Controls.Add(this.btnnuevacompra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnprocesarcompra);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbvaleregalo;
        private System.Windows.Forms.RadioButton rdbtarjetacredito;
        private System.Windows.Forms.RadioButton rdbefectivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button btnprocesarcompra;
        private System.Windows.Forms.Label lblcantidadimpresorascomprada;
        private System.Windows.Forms.Label lblpreciounitarioconiva;
        private System.Windows.Forms.Label lbltotalsindescuento;
        private System.Windows.Forms.Label lblformapago;
        private System.Windows.Forms.Label lbldescuentorealizado;
        private System.Windows.Forms.Label lbltotalpagar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnnuevacompra;
    }
}

