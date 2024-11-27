namespace TrabajodeCursoBetaV1
{
    partial class FormInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventario));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            txtStock = new TextBox();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            txtProducto = new TextBox();
            txtCodigo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvProductos = new DataGridView();
            groupBox2 = new GroupBox();
            button1 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label1 = new Label();
            txtBuscar = new TextBox();
            rbPorCodigo = new RadioButton();
            rbPorNombre = new RadioButton();
            button5 = new Button();
            button6 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtProducto);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(305, 423);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Producto";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(128, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 137);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += Agregar;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtStock.Location = new Point(106, 377);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(173, 27);
            txtStock.TabIndex = 9;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtPrecio.Location = new Point(106, 336);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(173, 27);
            txtPrecio.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtDescripcion.Location = new Point(106, 263);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(173, 61);
            txtDescripcion.TabIndex = 7;
            // 
            // txtProducto
            // 
            txtProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtProducto.Location = new Point(106, 223);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(173, 27);
            txtProducto.TabIndex = 6;
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtCodigo.Location = new Point(106, 175);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(173, 27);
            txtCodigo.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(49, 380);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 4;
            label6.Text = "Stock:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(44, 339);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 3;
            label5.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(6, 266);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 2;
            label4.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(23, 226);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 1;
            label3.Text = "Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(38, 178);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 0;
            label2.Text = "Codigo:";
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(335, 90);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(506, 244);
            dgvProductos.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(335, 351);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(506, 94);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Botones de Accion";
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(27, 26);
            button1.Name = "button1";
            button1.Size = new Size(62, 52);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += Agregar;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Location = new Point(376, 26);
            button4.Name = "button4";
            button4.Size = new Size(62, 52);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += Eliminar;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(291, 26);
            button3.Name = "button3";
            button3.Size = new Size(62, 52);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += Editar;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(114, 26);
            button2.Name = "button2";
            button2.Size = new Size(62, 52);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += Guardar;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(312, 22);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 3;
            label1.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtBuscar.Location = new Point(379, 19);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(394, 27);
            txtBuscar.TabIndex = 4;
            // 
            // rbPorCodigo
            // 
            rbPorCodigo.AutoSize = true;
            rbPorCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbPorCodigo.Location = new Point(462, 60);
            rbPorCodigo.Name = "rbPorCodigo";
            rbPorCodigo.Size = new Size(107, 24);
            rbPorCodigo.TabIndex = 5;
            rbPorCodigo.TabStop = true;
            rbPorCodigo.Text = "Por Codigo";
            rbPorCodigo.UseVisualStyleBackColor = true;
            // 
            // rbPorNombre
            // 
            rbPorNombre.AutoSize = true;
            rbPorNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rbPorNombre.Location = new Point(595, 60);
            rbPorNombre.Name = "rbPorNombre";
            rbPorNombre.Size = new Size(116, 24);
            rbPorNombre.TabIndex = 6;
            rbPorNombre.TabStop = true;
            rbPorNombre.Text = "Por Nombre";
            rbPorNombre.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackgroundImage = (Image)resources.GetObject("button5.BackgroundImage");
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Location = new Point(779, 12);
            button5.Name = "button5";
            button5.Size = new Size(62, 47);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += Buscar;
            // 
            // button6
            // 
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Location = new Point(205, 26);
            button6.Name = "button6";
            button6.Size = new Size(62, 52);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += Cargar;
            // 
            // FormInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 495);
            Controls.Add(button5);
            Controls.Add(rbPorNombre);
            Controls.Add(rbPorCodigo);
            Controls.Add(txtBuscar);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(dgvProductos);
            Controls.Add(groupBox1);
            Name = "FormInventario";
            Text = " ";
            Load += FormInventario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dgvProductos;
        private GroupBox groupBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtStock;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private TextBox txtProducto;
        private TextBox txtCodigo;
        private TextBox txtBuscar;
        private RadioButton rbPorCodigo;
        private RadioButton rbPorNombre;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button1;
        private Button button6;
    }
}