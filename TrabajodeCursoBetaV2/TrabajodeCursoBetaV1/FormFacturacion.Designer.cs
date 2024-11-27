namespace TrabajodeCursoBetaV2
{
    partial class FormFacturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpDatosProducto = new GroupBox();
            txtCodigoProducto = new TextBox();
            txtCantidad = new TextBox();
            btnAgregarProducto = new Button();
            dgvFactura = new DataGridView();
            grpTotales = new GroupBox();
            lblSubtotal = new Label();
            lblIVA = new Label();
            lblTotal = new Label();
            btnProcesarFactura = new Button();
            grpDatosProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).BeginInit();
            grpTotales.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatosProducto
            // 
            grpDatosProducto.Controls.Add(txtCodigoProducto);
            grpDatosProducto.Controls.Add(txtCantidad);
            grpDatosProducto.Controls.Add(btnAgregarProducto);
            grpDatosProducto.Location = new Point(12, 8);
            grpDatosProducto.Name = "grpDatosProducto";
            grpDatosProducto.Size = new Size(300, 150);
            grpDatosProducto.TabIndex = 4;
            grpDatosProducto.TabStop = false;
            grpDatosProducto.Text = "Datos del Producto";
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Location = new Point(20, 30);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(150, 27);
            txtCodigoProducto.TabIndex = 0;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(20, 70);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(150, 27);
            txtCantidad.TabIndex = 1;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(20, 110);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(150, 30);
            btnAgregarProducto.TabIndex = 2;
            btnAgregarProducto.Text = "Agregar a Factura";
            // 
            // dgvFactura
            // 
            dgvFactura.ColumnHeadersHeight = 29;
            dgvFactura.Location = new Point(12, 188);
            dgvFactura.Name = "dgvFactura";
            dgvFactura.ReadOnly = true;
            dgvFactura.RowHeadersWidth = 51;
            dgvFactura.Size = new Size(600, 200);
            dgvFactura.TabIndex = 5;
            // 
            // grpTotales
            // 
            grpTotales.Controls.Add(lblSubtotal);
            grpTotales.Controls.Add(lblIVA);
            grpTotales.Controls.Add(lblTotal);
            grpTotales.Location = new Point(642, 288);
            grpTotales.Name = "grpTotales";
            grpTotales.Size = new Size(300, 150);
            grpTotales.TabIndex = 6;
            grpTotales.TabStop = false;
            grpTotales.Text = "Totales";
            // 
            // lblSubtotal
            // 
            lblSubtotal.Location = new Point(20, 30);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(150, 20);
            lblSubtotal.TabIndex = 0;
            lblSubtotal.Text = "Subtotal: $0.00";
            // 
            // lblIVA
            // 
            lblIVA.Location = new Point(20, 70);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(150, 20);
            lblIVA.TabIndex = 1;
            lblIVA.Text = "IVA: $0.00";
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(20, 110);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(150, 20);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total: $0.00";
            // 
            // btnProcesarFactura
            // 
            btnProcesarFactura.Location = new Point(642, 458);
            btnProcesarFactura.Name = "btnProcesarFactura";
            btnProcesarFactura.Size = new Size(150, 30);
            btnProcesarFactura.TabIndex = 7;
            btnProcesarFactura.Text = "Procesar Factura";
            // 
            // FormFacturacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 497);
            Controls.Add(grpDatosProducto);
            Controls.Add(dgvFactura);
            Controls.Add(grpTotales);
            Controls.Add(btnProcesarFactura);
            Name = "FormFacturacion";
            Text = "FormFacturacion";
            grpDatosProducto.ResumeLayout(false);
            grpDatosProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFactura).EndInit();
            grpTotales.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatosProducto;
        private TextBox txtCodigoProducto;
        private TextBox txtCantidad;
        private Button btnAgregarProducto;
        private DataGridView dgvFactura;
        private GroupBox grpTotales;
        private Label lblSubtotal;
        private Label lblIVA;
        private Label lblTotal;
        private Button btnProcesarFactura;
    }
}