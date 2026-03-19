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
    public partial class frmMaterias : Form
    {
        datos datos = new datos();
        DataSet ds;
        public frmMaterias()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMaterias_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            frmMateria materia = new frmMateria();
            materia.ShowDialog();
            frmMaterias_Load(sender, e);
        }

        private void frmMaterias_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar("SELECT * FROM Materias");
                if (ds != null)
                {
                    dgvMaterias.DataSource = ds.Tables[0];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void dgvMaterias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMateria materia = new frmMateria(
               Convert.ToInt32(dgvMaterias.CurrentRow.Cells[0].Value),
               dgvMaterias.CurrentRow.Cells[1].Value.ToString(),
               dgvMaterias.CurrentRow.Cells[2].Value.ToString());
            materia.ShowDialog();
        }
    }
}
