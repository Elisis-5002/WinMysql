namespace WinMysql.Vistas
{
    partial class frmAsistencia
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
            dtpFecha = new DateTimePicker();
            label1 = new Label();
            dgvAlumnos = new DataGridView();
            splitContainer1 = new SplitContainer();
            btnMostrar = new Button();
            dgvAsistencia = new DataGridView();
            btnGuardar = new Button();
            gpbAsistencia = new GroupBox();
            rdbAusente = new RadioButton();
            rdbPresente = new RadioButton();
            label2 = new Label();
            txtNoControl = new TextBox();
            splitContainer2 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).BeginInit();
            gpbAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(335, 54);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(385, 31);
            dtpFecha.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 26);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 1;
            label1.Text = "Fecha";
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Dock = DockStyle.Fill;
            dgvAlumnos.Location = new Point(0, 0);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 62;
            dgvAlumnos.Size = new Size(303, 660);
            dgvAlumnos.TabIndex = 2;
            dgvAlumnos.CellContentClick += dgvAlumnos_CellContentClick;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvAlumnos);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnMostrar);
            splitContainer1.Panel2.Controls.Add(btnGuardar);
            splitContainer1.Panel2.Controls.Add(gpbAsistencia);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(txtNoControl);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1095, 660);
            splitContainer1.SplitterDistance = 303;
            splitContainer1.TabIndex = 3;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(595, 191);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(112, 34);
            btnMostrar.TabIndex = 7;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // dgvAsistencia
            // 
            dgvAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencia.Dock = DockStyle.Fill;
            dgvAsistencia.Location = new Point(0, 0);
            dgvAsistencia.Name = "dgvAsistencia";
            dgvAsistencia.RowHeadersWidth = 62;
            dgvAsistencia.Size = new Size(788, 397);
            dgvAsistencia.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(595, 113);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // gpbAsistencia
            // 
            gpbAsistencia.Controls.Add(rdbAusente);
            gpbAsistencia.Controls.Add(rdbPresente);
            gpbAsistencia.Location = new Point(29, 113);
            gpbAsistencia.Name = "gpbAsistencia";
            gpbAsistencia.Size = new Size(300, 112);
            gpbAsistencia.TabIndex = 4;
            gpbAsistencia.TabStop = false;
            gpbAsistencia.Text = "Estado";
            // 
            // rdbAusente
            // 
            rdbAusente.AutoSize = true;
            rdbAusente.Location = new Point(19, 78);
            rdbAusente.Name = "rdbAusente";
            rdbAusente.Size = new Size(101, 29);
            rdbAusente.TabIndex = 1;
            rdbAusente.TabStop = true;
            rdbAusente.Text = "Ausente";
            rdbAusente.UseVisualStyleBackColor = true;
            rdbAusente.CheckedChanged += rdbAusente_CheckedChanged;
            // 
            // rdbPresente
            // 
            rdbPresente.AutoSize = true;
            rdbPresente.Location = new Point(16, 43);
            rdbPresente.Name = "rdbPresente";
            rdbPresente.Size = new Size(104, 29);
            rdbPresente.TabIndex = 0;
            rdbPresente.TabStop = true;
            rdbPresente.Text = "Presente";
            rdbPresente.UseVisualStyleBackColor = true;
            rdbPresente.CheckedChanged += rdbPresente_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 26);
            label2.Name = "label2";
            label2.Size = new Size(170, 25);
            label2.TabIndex = 3;
            label2.Text = "Número de Control:";
            // 
            // txtNoControl
            // 
            txtNoControl.Location = new Point(29, 54);
            txtNoControl.Name = "txtNoControl";
            txtNoControl.Size = new Size(209, 31);
            txtNoControl.TabIndex = 2;
            txtNoControl.TextChanged += txtNoControl_TextChanged;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dtpFecha);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(dgvAsistencia);
            splitContainer2.Size = new Size(788, 660);
            splitContainer2.SplitterDistance = 259;
            splitContainer2.TabIndex = 8;
            // 
            // frmAsistencia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 660);
            Controls.Add(splitContainer1);
            Name = "frmAsistencia";
            Text = "Asistencia";
            Load += frmAsistencia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).EndInit();
            gpbAsistencia.ResumeLayout(false);
            gpbAsistencia.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpFecha;
        private Label label1;
        private DataGridView dgvAlumnos;
        private SplitContainer splitContainer1;
        private GroupBox gpbAsistencia;
        private Label label2;
        private TextBox txtNoControl;
        private RadioButton rdbAusente;
        private RadioButton rdbPresente;
        private Button btnGuardar;
        private DataGridView dgvAsistencia;
        private Button btnMostrar;
        private SplitContainer splitContainer2;
    }
}