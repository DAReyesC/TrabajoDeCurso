using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajodeCursoBetaV2;

namespace TrabajodeCursoBetaV1
{
    public partial class MenuForm : Form
    {
        FormFacturacion? formFacturacion;
        FormInventario? formInventario;
        private bool _isMenuVisible = false;
        public MenuForm()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void AlternarVisibilidad(object sender, EventArgs e)
        {
            _isMenuVisible = !_isMenuVisible;
            panelMenu.Visible = _isMenuVisible;
        }

        private void MostrarFormularioEnTabPage(Form formulario, TabPage tabPage)
        {
            
            tabPage.Controls.Clear(); 
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            tabPage.Controls.Add(formulario);
            formulario.Show();

          
            tabControlCentral.SelectedTab = tabPage;
        }


        private void Salir(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea salir?",
               "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Inventario(object sender, EventArgs e)
        {
            if (formInventario == null)
            {
                formInventario = new FormInventario();
            }

            MostrarFormularioEnTabPage(formInventario, tabPage2);
        }

        private void Facturacion(object sender, EventArgs e)
        {
            if (formFacturacion == null)
            {
                formFacturacion = new FormFacturacion();
            }

            MostrarFormularioEnTabPage(formFacturacion, tabPage1);
        }

        
    }
}
