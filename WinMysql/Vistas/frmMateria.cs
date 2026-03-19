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
    public partial class frmMateria : Form
    {
        datos dt = new datos();
        bool updating = false;
        int id = 0;
        public frmMateria()
        {
            InitializeComponent();
        }

        public frmMateria(int id, string materia, string cve)
        {
            InitializeComponent();
          
            txtMateria.Text = materia;
            txtCVE.Text = cve;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            

            if(updating  == false)
            {
                
                bool resultado = dt.ejecutarComando(
                $"INSERT INTO Materias (Materia, CVE) " +
                $"VALUES ('{txtMateria.Text}','{ txtCVE.Text}')");
            if (resultado) { MessageBox.Show("Materia agregada correctamente"); }
            else
            {
                MessageBox.Show("Error al agregar la materia");
            }

            } else
            {
                bool resultado = dt.ejecutarComando(
                $"UPDATE Materias SET Materia = '{txtMateria.Text}', CVE = '{txtCVE.Text}' " +
                $"WHERE idMateria = {id}");
                if (resultado) { MessageBox.Show("Materia actualizada correctamente"); }
                else
                {
                    MessageBox.Show("Error al actualizar la materia");
                }
            }
            

        }
    }
}
