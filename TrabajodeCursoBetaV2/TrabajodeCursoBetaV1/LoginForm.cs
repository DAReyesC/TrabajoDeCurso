namespace TrabajodeCursoBetaV1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void IniciarSesion(object sender, EventArgs e)
        {
            string username = "ABazar_24";
            string contraseña = "2024";

            string usuarioingresado = txtUsuario.Text;
            string contraseñaingresada = txtContraseña.Text;

            if (string.IsNullOrWhiteSpace(usuarioingresado) || string.IsNullOrWhiteSpace(contraseñaingresada))
            {
                MessageBox.Show("Campos vacios, por favor ingrese los datos solicitados", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (username == usuarioingresado && contraseña == contraseñaingresada)
            {
                var MenuForm = new MenuForm();
                MenuForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña o nombre de usuario incorrectos", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void Salir(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro que quiere cerrar sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                LoginForm formIniciarCesión = new LoginForm();
                formIniciarCesión.Show();
                this.Close();
            }


        }
    }
}
