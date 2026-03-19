namespace WinMysql.Vistas
{
    partial class frmProfesores
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
            txtProfesor = new TextBox();
            splitContainer1 = new SplitContainer();
            btnImportar = new Button();
            btnAgregar = new Button();
            dgvProfesores = new DataGridView();
            ofdExcel = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProfesores).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 0;
            label1.Text = "Profesor";
            // 
            // txtProfesor
            // 
            txtProfesor.Location = new Point(21, 37);
            txtProfesor.Name = "txtProfesor";
            txtProfesor.Size = new Size(623, 31);
            txtProfesor.TabIndex = 1;
            txtProfesor.TextChanged += txtProfesor_TextChanged;
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
            splitContainer1.Panel1.Controls.Add(btnImportar);
            splitContainer1.Panel1.Controls.Add(btnAgregar);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(txtProfesor);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvProfesores);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 137;
            splitContainer1.TabIndex = 2;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(676, 83);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(112, 34);
            btnImportar.TabIndex = 3;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(676, 34);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvProfesores
            // 
            dgvProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfesores.Dock = DockStyle.Fill;
            dgvProfesores.Location = new Point(0, 0);
            dgvProfesores.Name = "dgvProfesores";
            dgvProfesores.RowHeadersWidth = 62;
            dgvProfesores.Size = new Size(800, 309);
            dgvProfesores.TabIndex = 0;
            // 
            // ofdExcel
            // 
            ofdExcel.FileName = "ofdExcel";
            // 
            // frmProfesores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "frmProfesores";
            Text = "Profesores";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProfesores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtProfesor;
        private SplitContainer splitContainer1;
        private Button btnImportar;
        private Button btnAgregar;
        private DataGridView dgvProfesores;
        private OpenFileDialog ofdExcel;
    }
}