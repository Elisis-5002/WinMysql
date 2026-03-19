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
    public partial class frmAgregarProf : Form
    {
        datos dt = new datos();
        bool updating = false;
        int id = 0;
        public frmAgregarProf()
        {
            InitializeComponent();
        }

        public frmAgregarProf(int id, string cedProf, string nombre, string paterno, string materno)
        {
            InitializeComponent();
            txtCedProf.Text = cedProf;
            txtNombre.Text = nombre;
            txtPaterno.Text = paterno;
            txtMaterno.Text = materno;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (updating == false)
            {
                bool resultado = dt.ejecutarComando($"INSERT INTO Profesores (ced_prof, nombre, paterno," +
                    $" materno) VALUES" +
                    $" ('{txtCedProf.Text}', '{txtNombre.Text}', '{txtPaterno.Text}'," +
                    $" '{txtMaterno.Text}')");

                if (resultado)
                {
                    MessageBox.Show("Profesor agregado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al agregar profesor");
                }
            }
            else
            {
                bool resultado = dt.ejecutarComando($"UPDATE Profesores SET ced_prof='{txtCedProf.Text}'" +
                    $"', nombre='{txtNombre.Text}', paterno='{txtPaterno.Text}', materno='{txtMaterno.Text}', " +
                    $" WHERE idProfesores={id}");
                if (resultado)
                {
                    MessageBox.Show("Profesor actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar profesor");
                }
            }

        }
    }
}
