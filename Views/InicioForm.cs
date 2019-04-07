using Controllers;
using System;
using System.Windows.Forms;

namespace Views
{
    public partial class InicioForm : Form
    {
        MenuStrip menu;

        public InicioForm()
        {
            InitializeComponent();
        }

        public InicioForm(string nombreUsuario)
        {
            InitializeComponent();
            IniciarMenu(nombreUsuario);
        }

        public void IniciarMenu(string nombreUsuario)
        {
            Login l = new Login();
            int rolUsuario = int.Parse(l.rolUsuario(nombreUsuario));

            MenuStrip menu = new MenuStrip();

            ToolStripMenuItem usuarios = new ToolStripMenuItem("Usuarios", null, usuariosClick);
            ToolStripMenuItem docentes = new ToolStripMenuItem("Docentes", null, docentesClick);
            ToolStripMenuItem portafolio = new ToolStripMenuItem("Portafolio", null, portafolioClick);

            switch (rolUsuario)
            {
                case 1: menu.Items.Add(portafolio); break;
                case 2: menu.Items.Add(docentes); menu.Items.Add(portafolio); break;
                case 3: menu.Items.Add(usuarios); menu.Items.Add(docentes); menu.Items.Add(portafolio); break;
            }
            this.menu = menu;
            Controls.Add(menu);
        }

        private void usuariosClick(object sender, EventArgs e)
        {
            UsuariosForm u = new UsuariosForm();
            u.Show();
        }

        private void docentesClick(object sender, EventArgs e)
        {
            DocentesForm d = new DocentesForm();
            d.Show();
        }
        private void portafolioClick(object sender, EventArgs e)
        {
            fmPortafolioDocente p = new fmPortafolioDocente();
            p.Show();
        }



        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmCliente Cliente = new frmCliente();
            //Cliente.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmEmpleado Empleado = new frmEmpleado();
            //Empleado.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmProducto Producto = new frmProducto();
            //Producto.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmVentas Ventas = new frmVentas();
            //Ventas.Show();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
