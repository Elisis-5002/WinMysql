using MySqlConnector;
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
    
    public partial class frmAgregarAlum : Form
    {
        datos dt = new datos();
        bool updating = false;
        int id = 0;
        public frmAgregarAlum()
        {
            InitializeComponent();
        }
        public frmAgregarAlum(int id, string noControl, string nombre, string paterno, string materno)
        {
            InitializeComponent();
            txtNoControl.Text = noControl;
            txtNombre.Text = nombre;    
            txtPaterno.Text = paterno;
            txtMaterno.Text = materno;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (updating == false)
            {
                bool resultado = dt.ejecutarComando($"INSERT INTO Alumnos (noControl, nombre, paterno," +
                    $" materno) VALUES" +
                    $" ('{txtNoControl.Text}', '{txtNombre.Text}', '{txtPaterno.Text}'," +
                    $" '{txtMaterno.Text}')");

                if (resultado)
                {
                    MessageBox.Show("Alumno agregado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al agregar alumno");
                }
            }
            else
            {
                bool resultado = dt.ejecutarComando($"UPDATE Alumnos SET noControl='{txtNoControl.Text}'" +
                    $"', nombre='{txtNombre.Text}', paterno='{txtPaterno.Text}', materno='{txtMaterno.Text}', " +
                    $" WHERE idAlumnos={id}");
                if (resultado)
                {
                    MessageBox.Show("Alumno actualizado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar alumno");
                }
            }
        }
    }
}
