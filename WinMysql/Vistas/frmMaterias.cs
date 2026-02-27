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
                datos.ejecutar(); 
            } catch (Exception ex)
            {

            }
        }
    }
}
