using FastReport.DevComponents.DotNetBar;
using FastReport.Editor.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinMysql.Clases;

namespace WinMysql.Vistas
{
    public partial class frmAsistencia : Form
    {
        datos datos = new datos();

        bool updating = false;
        int presente;

        public frmAsistencia()
        {
            InitializeComponent();
        }

        private void Busqueda()
        {
            DataSet ds = datos.ejecutar(
                $"SELECT noControl, nombre, paterno, materno FROM Alumnos " +
                $"WHERE noControl LIKE '{txtNoControl.Text}%' " +
                $"ORDER BY noControl");
            if (ds != null)
            {
                dgvAlumnos.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Ingrese un No. Control válido");
            }
        }
        private Boolean Busqueda2()
        {
            DataSet ds = datos.ejecutar(
                $"SELECT noControl, nombre, paterno, materno FROM Alumnos " +
                $"WHERE noControl LIKE '{txtNoControl.Text}%' " +
                $"ORDER BY noControl");
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Alumno no registrado");
                return false;
            }
        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            Busqueda();
        }


        private void txtNoControl_TextChanged(object sender, EventArgs e)
        {
            Busqueda();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            txtNoControl.Focus();
        }

        private void MarcarAsistencia()
        {
            string noControl = txtNoControl.Text.Trim();

            for (int i = 0; i < dgvAlumnos.Rows.Count - 1; i++)
            {
                if (dgvAlumnos.Rows[i].IsNewRow) continue;

                if ((dgvAlumnos.Rows[i].Cells[1].Value.ToString() == noControl))
                {
                    bool estado = Convert.ToBoolean(dgvAlumnos.Rows[i].Cells[0].Value ?? false);
                    dgvAlumnos.Rows[i].Cells[0].Value = !estado;

                    if (!estado)
                    {
                        dgvAlumnos.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }

                    break;
                }
            }

            txtNoControl.Clear();
        }

        private void txtNoControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Busqueda2())
                {
                    MarcarAsistencia();

                }
            }

        }

        private void dgvAlumnos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtNoControl.Text = dgvAlumnos.CurrentRow.Cells[1].Value.ToString();
            txtNoControl.Focus();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            GuardarAsistencia();  // guardas en BD
        }

        private void GuardarAsistencia()
        {
            string fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

            bool todoCorrecto = true;

            for (int i = 0; i < dgvAlumnos.Rows.Count; i++)
            {
                if (dgvAlumnos.Rows[i].IsNewRow) continue;

                string noControl = dgvAlumnos.Rows[i].Cells[1].Value.ToString();

                bool presente = Convert.ToBoolean(
                    dgvAlumnos.Rows[i].Cells[0].Value ?? false);

                int estado = presente ? 1 : 0;

                string query = $@"
                INSERT INTO Asistencia (fecha, presente, idAlumno)
                VALUES ('{fecha}', {estado},
                (SELECT idAlumnos FROM Alumnos WHERE noControl = '{noControl}' LIMIT 1))
                ON DUPLICATE KEY UPDATE presente = {estado}";

                bool resultado = datos.ejecutarComando(query);

                if (!resultado)
                {
                    todoCorrecto = false;
                }
            }

            if (todoCorrecto)
                MessageBox.Show("Asistencia guardada correctamente");
            else
                MessageBox.Show("Algunos registros fallaron ");
        }




        private void dtpFecha_ValueChanged_1(object sender, EventArgs e)
        {


        }

        private void dtpFecha_CloseUp_1(object sender, EventArgs e)
        {
            txtNoControl.Focus();
        }

        private void Todos()
        {
            for (int i = 0; i < dgvAlumnos.Rows.Count; i++)
            {
                if (dgvAlumnos.Rows[i].IsNewRow) continue;
                dgvAlumnos.Rows[i].Cells[0].Value = true;
                dgvAlumnos.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            Todos();
            MarcarAsistencia();
        }

        private void txtNoControl_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
