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
            try
            {
                ds = datos.ejecutar("SELECT * FROM materias");
                if (ds != null)
                {
                    dgvMaterias.DataSource = ds.Tables[0];
                }

                } catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 

            }
        }
    }
}
