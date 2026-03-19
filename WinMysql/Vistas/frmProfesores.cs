using OfficeOpenXml;
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
    public partial class frmProfesores : Form
    {
        datos datos = new datos();

        public frmProfesores()
        {
            InitializeComponent();
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarProf agregarProf = new frmAgregarProf();
            agregarProf.Show();
        }

        private void Busqueda()
        {
            DataSet ds = datos.ejecutar($"Select ced_prof,nombre,paterno,materno From Profesores" +
                $" Where nombre like '{txtProfesor.Text}%'");
            if (ds != null)
            {
                dgvProfesores.DataSource = ds.Tables[0];
            }
        }

        private void frmProfesores_Load(object sender, EventArgs e)
        {
            Busqueda();
        }

        private void txtProfesor_TextChanged(object sender, EventArgs e)
        {
            Busqueda();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            String path;
            DialogResult dr = ofdExcel.ShowDialog();
            if (dr == DialogResult.OK)
            {
                path = ofdExcel.FileName;
                ExcelPackage.License.SetNonCommercialPersonal("Ana Elisa"); //Libreria funcion no Comercial
                using (var package = new ExcelPackage(new FileInfo(path)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    int rowCount = worksheet.Dimension.Rows;
                    int colCount = worksheet.Dimension.Columns;
                    DataTable dt = new DataTable();
                    for (int col = 1; col <= colCount; col++)
                    {
                        dt.Columns.Add(worksheet.Cells[1, col].Value.ToString());
                    }
                    for (int row = 2; row <= rowCount; row++)
                    {
                        DataRow drNew = dt.NewRow();
                        for (int col = 1; col <= colCount; col++)
                        {
                            drNew[col - 1] = worksheet.Cells[row, col].Value.ToString();
                        }
                        dt.Rows.Add(drNew);
                        String comando = $"Insert Into Profesores (ced_prof,nombre," +
                            $" paterno,materno) Values('{drNew.ItemArray[0]}','" +
                            $"{drNew.ItemArray[1]}','{drNew.ItemArray[2]}','" +
                            $"{drNew.ItemArray[3]}')";

                        datos.ejecutarComando(comando);
                    }
                    dgvProfesores.DataSource = dt;
                }
            }
        }
    }
}
