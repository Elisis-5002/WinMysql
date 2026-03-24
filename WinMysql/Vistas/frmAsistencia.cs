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
        int presente;
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

        private void Asistencia()
        {
            DataSet ds2 = datos.ejecutar($"Select idAsistencia, fecha, presente, noControl " +
                $"From Asistencia A JOIN Alumnos AL ON A.idAlumno = AL.idAlumnos " +
                $" Where fecha = '{dtpFecha.Value.ToString("yyyy-MM-dd")}%'");
            if (ds2 != null)
            {
                dgvAsistencia.DataSource = ds2.Tables[0];
            }
        }

        private void rdbAusente_CheckedChanged(object sender, EventArgs e)
        {
            presente = 0;

        }

        private void frmAsistencia_Load(object sender, EventArgs e)
        {
            Busqueda();
            Asistencia();
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (updating == false)
            {
                bool resultado = datos.ejecutarComando($"INSERT INTO Asistencia (fecha, presente, idAlumno) VALUES " +
                    $" ('{dtpFecha.Value.ToString("yyyy-MM-dd")}',{presente}, " +
                    $"(SELECT idAlumnos FROM Alumnos WHERE noControl = '{txtNoControl.Text}' LIMIT 1))");

                if (resultado)
                {
                    MessageBox.Show("Asistencia agregada correctamente");
                }
                else
                {
                    MessageBox.Show("Error al agregar asistencia, favor de llenar los campos");
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

        private void rdbPresente_CheckedChanged(object sender, EventArgs e)
        {
            presente = 1;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Asistencia();
        }

        private void txtNoControl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
