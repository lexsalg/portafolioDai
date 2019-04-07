using Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Views
{
    public partial class UsuariosForm : Form
    {
        UsuarioDto u = new UsuarioDto();
        BindingList<UsuarioDto> users = new BindingList<UsuarioDto>();
        List<UsuarioDto> temp_insert = new List<UsuarioDto>();
        List<UsuarioDto> temp_edit = new List<UsuarioDto>();
        List<UsuarioDto> temp_delete = new List<UsuarioDto>();

        public UsuariosForm()
        {
            InitializeComponent();
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            users.AddNew();
            grdData.Rows[grdData.Rows.Count - 1].Cells["type"].Value = "temp";
        }

        private void grdData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (grdData.Rows[e.RowIndex].Cells["type"].Value != null)
                    grdData.Rows[e.RowIndex].Cells["status"].Value = "Editado";
            }

        }

        private void CargarGrilla()
        {
            users = u.ListarUsuarios();
            grdData.DataSource = users;
            foreach (DataGridViewRow f in grdData.Rows)
            {
                f.Cells["type"].Value = "noTemp";
            }
        }

        void LlenarTemporales()
        {
            foreach (DataGridViewRow f in grdData.Rows)
            {
                if (f.Cells["type"].Value != null && f.Cells["status"].Value != null && f.Cells["status"].Value.ToString() == "Editado")
                {
                    UsuarioDto _u = new UsuarioDto();
                    switch (f.Cells["type"].Value.ToString())
                    {
                        case "noTemp":
                            _u.IdUsuario = int.Parse(f.Cells["IdUsuario"].Value.ToString());
                            _u.NombreUsuario = f.Cells["NombreUsuario"].Value != null ? f.Cells["NombreUsuario"].Value.ToString() : null;
                            _u.Password = f.Cells["Password"].Value != null ? f.Cells["Password"].Value.ToString() : null;
                            _u.Rol = f.Cells["Rol"].Value != null ? int.Parse(f.Cells["Rol"].Value.ToString()) : 1;
                            _u.Nombre = f.Cells["Nombre"].Value != null ? f.Cells["Nombre"].Value.ToString() : null;
                            _u.Apellidos = f.Cells["Apellidos"].Value != null ? f.Cells["Apellidos"].Value.ToString() : null;
                            _u.Email = f.Cells["Email"].Value != null ? f.Cells["Email"].Value.ToString() : null;
                            temp_edit.Add(_u);
                            break;

                        case "temp":
                            _u.NombreUsuario = f.Cells["NombreUsuario"].Value != null ? f.Cells["NombreUsuario"].Value.ToString() : null;
                            _u.Password = f.Cells["Password"].Value != null ? f.Cells["Password"].Value.ToString() : null;
                            _u.Rol = f.Cells["Rol"].Value != null ? int.Parse(f.Cells["Rol"].Value.ToString()) : 1;
                            _u.Nombre = f.Cells["Nombre"].Value != null ? f.Cells["Nombre"].Value.ToString() : null;
                            _u.Apellidos = f.Cells["Apellidos"].Value != null ? f.Cells["Apellidos"].Value.ToString() : null;
                            _u.Email = f.Cells["Email"].Value != null ? f.Cells["Email"].Value.ToString() : null;
                            temp_insert.Add(_u);
                            break;
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grdData.SelectedRows.Count != 0)
            {
                if (grdData.Rows[grdData.SelectedRows[0].Index].Cells["type"].Value.ToString() == "noTemp")
                {
                    UsuarioDto _u = new UsuarioDto();
                    _u.IdUsuario = int.Parse(grdData.Rows[grdData.SelectedRows[0].Index].Cells["IdUsuario"].Value.ToString());
                    temp_delete.Add(_u);
                }
                grdData.Rows.Remove(grdData.Rows[grdData.SelectedRows[0].Index]);
            }
            else MessageBox.Show("Seleccione 1 o más filas para eliminar");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            LlenarTemporales();
            u.ActualizarUsuario(temp_insert, temp_edit, temp_delete);

            CargarGrilla();

            temp_insert = new List<UsuarioDto>();
            temp_edit = new List<UsuarioDto>();
            temp_delete = new List<UsuarioDto>();
        }
    }
}
