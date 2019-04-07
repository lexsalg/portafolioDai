using Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Views
{
    public partial class DocentesForm : Form
    {
        DocenteDto u = new DocenteDto();
        BindingList<DocenteDto> docentes = new BindingList<DocenteDto>();
        List<DocenteDto> temp_insert = new List<DocenteDto>();
        List<DocenteDto> temp_edit = new List<DocenteDto>();
        List<DocenteDto> temp_delete = new List<DocenteDto>();

        public DocentesForm()
        {
            InitializeComponent();
        }


        private void DocentesForm_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            docentes.AddNew();
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
            docentes = u.ListarDocentes();
            grdData.DataSource = docentes;
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
                    DocenteDto _u = new DocenteDto();
                    switch (f.Cells["type"].Value.ToString())
                    {
                        case "noTemp":
                            _u.IdDocente= int.Parse(f.Cells["IdDocente"].Value.ToString());
                            _u.Nombre = f.Cells["Nombre"].Value != null ? f.Cells["Nombre"].Value.ToString() : null;
                            _u.Apellidos = f.Cells["Apellidos"].Value != null ? f.Cells["Apellidos"].Value.ToString() : null;
                            _u.Email = f.Cells["Email"].Value != null ? f.Cells["Email"].Value.ToString() : null;
                            temp_edit.Add(_u);
                            break;

                        case "temp":
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
                    DocenteDto _u = new DocenteDto();
                    _u.IdDocente = int.Parse(grdData.Rows[grdData.SelectedRows[0].Index].Cells["IdDocente"].Value.ToString());
                    temp_delete.Add(_u);
                }
                grdData.Rows.Remove(grdData.Rows[grdData.SelectedRows[0].Index]);
            }
            else MessageBox.Show("Seleccione 1 o más filas para eliminar");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            LlenarTemporales();
            u.ActualizarDocente(temp_insert, temp_edit, temp_delete);

            CargarGrilla();

            temp_insert = new List<DocenteDto>();
            temp_edit = new List<DocenteDto>();
            temp_delete = new List<DocenteDto>();

        }


    }
}
