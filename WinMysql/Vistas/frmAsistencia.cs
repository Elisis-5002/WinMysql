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
        int id = 0;
        public frmAsistencia()
        {
            InitializeComponent();
        }

        public frmAsistencia(int id, DateTime fecha, int idAlumno)
        {
            InitializeComponent();

        }
        private void Busqueda()
        {
            DataSet ds = datos.ejecutar($"Select nocontrol,nombre,paterno,materno From Alumnos" +
                $" Where nombre like '{txtNoControl.Text}%'");
            if (ds != null)
            {
                dgvAlumnos.DataSource = ds.Tables[0];
            }
        }


        private void rdbAusente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            Busqueda();
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (updating == false)
            {
                bool resultado = datos.ejecutarComando($"INSERT INTO Asistencia (fecha, idAlumno) VALUES" +
                    $" ('{dtpFecha.Value.ToString("yyyy-MM-dd")}', '{txtNoControl.Text}')");

                if (resultado)
                {
                    MessageBox.Show("Asistencia agregada correctamente");
                }
                else
                {
                    MessageBox.Show("Error al agregar asistencia");
                }
            }
            else
            {
                bool resultado = datos.ejecutarComando($"UPDATE Asistencia SET fecha='{dtpFecha.Text}'" +
                    $"', idAlumno='{txtNoControl.Text}'" +
                    $" WHERE idAsistencia={id}");
                if (resultado)
                {
                    MessageBox.Show("Asistencia actualizada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar asistencia");
                }
            }

        }
    }
}
