using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TrabajodeCursoBetaV1
{
    public partial class FormInventario : Form
    {
        private List<Producto> listaProductos;
        private readonly IArchivo gestorArchivos;

        public FormInventario()
        {
            InitializeComponent();
            listaProductos = new List<Producto>();
            gestorArchivos = new GestorArchivos();
            dgvProductos.CellClick += dgvProductos_CellClick; 
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaProductos;
        }

        private void Agregar(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                var nuevoProducto = new Producto
                {
                    Codigo = txtCodigo.Text,
                    Nombre = txtProducto.Text,
                    Descripcion = txtDescripcion.Text,
                    Precio = decimal.Parse(txtPrecio.Text),
                    Stock = int.Parse(txtStock.Text)
                };

                listaProductos.Add(nuevoProducto);
                CargarProductos();
                LimpiarCampos();
                MessageBox.Show("Producto agregado exitosamente.");
            }
        }

        private void Editar(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            var productoExistente = listaProductos.FirstOrDefault(p => p.Codigo == codigo);
            if (productoExistente != null)
            {
                if (ValidarCampos())
                {
                    productoExistente.Nombre = txtProducto.Text;
                    productoExistente.Descripcion = txtDescripcion.Text;
                    productoExistente.Precio = decimal.Parse(txtPrecio.Text);
                    productoExistente.Stock = int.Parse(txtStock.Text);
                    MessageBox.Show("Producto actualizado exitosamente.");
                    CargarProductos();
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void Eliminar(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            var productoEliminar = listaProductos.FirstOrDefault(p => p.Codigo == codigo);
            if (productoEliminar != null)
            {
                listaProductos.Remove(productoEliminar);
                MessageBox.Show("Producto eliminado exitosamente.");
                CargarProductos();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Producto no encontrado.");
            }
        }

        private void Buscar(object sender, EventArgs e)
        {
            string criterioBusqueda = txtBuscar.Text;
            var resultados = rbPorCodigo.Checked
                ? listaProductos.Where(p => p.Codigo.Contains(criterioBusqueda)).ToList()
                : listaProductos.Where(p => p.Nombre.Contains(criterioBusqueda)).ToList();

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = resultados;
        }

        private void Guardar(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                Title = "Guardar inventario como"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    gestorArchivos.GuardarEnArchivo(saveFileDialog.FileName, listaProductos);
                    MessageBox.Show("Archivo guardado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Cargar(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                Title = "Cargar inventario desde"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    listaProductos = gestorArchivos.CargarDesdeArchivo(openFileDialog.FileName);
                    CargarProductos();
                    MessageBox.Show("Archivo cargado exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtProducto.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtProducto.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                !decimal.TryParse(txtPrecio.Text, out _) ||
                !int.TryParse(txtStock.Text, out _))
            {
                MessageBox.Show("Por favor, completa todos los campos correctamente.");
                return false;
            }
            return true;
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                var productoSeleccionado = listaProductos[e.RowIndex];
                txtCodigo.Text = productoSeleccionado.Codigo;
                txtProducto.Text = productoSeleccionado.Nombre;
                txtDescripcion.Text = productoSeleccionado.Descripcion;
                txtPrecio.Text = productoSeleccionado.Precio.ToString();
                txtStock.Text = productoSeleccionado.Stock.ToString();
            }
        }
    }
}
