namespace WinMysql.Vistas
{
    partial class frmAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtAlumno = new TextBox();
            btnAgregar = new Button();
            btnImportar = new Button();
            splitContainer1 = new SplitContainer();
            dgvAlumnos = new DataGridView();
            ofdExcel = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 25);
            label1.TabIndex = 0;
            label1.Text = "Alumno";
            // 
            // txtAlumno
            // 
            txtAlumno.Location = new Point(12, 39);
            txtAlumno.Name = "txtAlumno";
            txtAlumno.Size = new Size(612, 31);
            txtAlumno.TabIndex = 1;
            txtAlumno.TextChanged += txtAlumno_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(653, 36);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(653, 78);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(112, 34);
            btnImportar.TabIndex = 3;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtAlumno);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvAlumnos);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 126;
            splitContainer1.TabIndex = 4;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Dock = DockStyle.Fill;
            dgvAlumnos.Location = new Point(0, 0);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 62;
            dgvAlumnos.Size = new Size(800, 320);
            dgvAlumnos.TabIndex = 0;
            // 
            // ofdExcel
            // 
            ofdExcel.FileName = "ofdExcel";
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnImportar);
            Controls.Add(btnAgregar);
            Controls.Add(splitContainer1);
            Name = "frmAlumnos";
            Text = "Alumnos";
            Load += frmAlumnos_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtAlumno;
        private Button btnAgregar;
        private Button btnImportar;
        private SplitContainer splitContainer1;
        private DataGridView dgvAlumnos;
        private OpenFileDialog ofdExcel;
    }
}