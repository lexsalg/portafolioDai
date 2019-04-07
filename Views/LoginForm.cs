using System;
using System.Windows.Forms;
using Views;

namespace Presentacion
{
    public partial class LoginForm : Form
    {
        public bool Verificar { get; set; }
        public string Id_Usuario;
        public string Usuario;
        public LoginForm()
        {
            InitializeComponent();
            Verificar = false;
        }

        void limpiarDatos()
        {
            txtUsuario.Clear();
            txtPassword.Clear();
        }

        void ingresar()
        {
            Controllers.Login l = new Controllers.Login();

            string resultado = l.login(txtUsuario.Text, txtPassword.Text);

            if (resultado == "")
            {
                Verificar = true;
                this.Hide();
                Inicio i = new Inicio();
                i.ShowDialog();
                this.Visible = true;
                limpiarDatos();
            }
            else MessageBox.Show(resultado);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ingresar();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ingresar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
