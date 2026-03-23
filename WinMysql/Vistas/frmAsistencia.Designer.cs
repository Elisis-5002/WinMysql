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
            gpbAsistencia = new GroupBox();
            rdbRetardo = new RadioButton();
            rdbAusente = new RadioButton();
            rdbPresente = new RadioButton();
            label2 = new Label();
            txtNoControl = new TextBox();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            gpbAsistencia.SuspendLayout();
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(59, 68);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(385, 31);
            dtpFecha.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 40);
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
            dgvAlumnos.Size = new Size(677, 517);
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
            splitContainer1.Panel2.Controls.Add(btnGuardar);
            splitContainer1.Panel2.Controls.Add(gpbAsistencia);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(txtNoControl);
            splitContainer1.Panel2.Controls.Add(dtpFecha);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(1141, 517);
            splitContainer1.SplitterDistance = 677;
            splitContainer1.TabIndex = 3;
            // 
            // gpbAsistencia
            // 
            gpbAsistencia.Controls.Add(rdbRetardo);
            gpbAsistencia.Controls.Add(rdbAusente);
            gpbAsistencia.Controls.Add(rdbPresente);
            gpbAsistencia.Location = new Point(59, 204);
            gpbAsistencia.Name = "gpbAsistencia";
            gpbAsistencia.Size = new Size(300, 150);
            gpbAsistencia.TabIndex = 4;
            gpbAsistencia.TabStop = false;
            gpbAsistencia.Text = "Estado";
            // 
            // rdbRetardo
            // 
            rdbRetardo.AutoSize = true;
            rdbRetardo.Location = new Point(19, 113);
            rdbRetardo.Name = "rdbRetardo";
            rdbRetardo.Size = new Size(99, 29);
            rdbRetardo.TabIndex = 2;
            rdbRetardo.TabStop = true;
            rdbRetardo.Text = "Retardo";
            rdbRetardo.UseVisualStyleBackColor = true;
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
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 138);
            label2.Name = "label2";
            label2.Size = new Size(170, 25);
            label2.TabIndex = 3;
            label2.Text = "Número de Control:";
            // 
            // txtNoControl
            // 
            txtNoControl.Location = new Point(235, 138);
            txtNoControl.Name = "txtNoControl";
            txtNoControl.Size = new Size(209, 31);
            txtNoControl.TabIndex = 2;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(59, 371);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // frmAsistencia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 517);
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
            gpbAsistencia.ResumeLayout(false);
            gpbAsistencia.PerformLayout();
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
        private RadioButton rdbRetardo;
        private Button btnGuardar;
    }
}