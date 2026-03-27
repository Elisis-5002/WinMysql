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
            splitContainer1 = new SplitContainer();
            btnTodos = new Button();
            btnGuardar = new Button();
            dtpFecha = new DateTimePicker();
            label1 = new Label();
            txtNoControl = new TextBox();
            dgvAlumnos = new DataGridView();
            Presente = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(btnTodos);
            splitContainer1.Panel1.Controls.Add(btnGuardar);
            splitContainer1.Panel1.Controls.Add(dtpFecha);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(txtNoControl);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvAlumnos);
            splitContainer1.Size = new Size(1223, 646);
            splitContainer1.SplitterDistance = 128;
            splitContainer1.TabIndex = 0;
            // 
            // btnTodos
            // 
            btnTodos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTodos.Location = new Point(1013, 15);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(198, 44);
            btnTodos.TabIndex = 4;
            btnTodos.Text = "Todos Presentes";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(1013, 65);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(198, 42);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarFont = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Location = new Point(325, 60);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(354, 31);
            dtpFecha.TabIndex = 2;
            dtpFecha.CloseUp += dtpFecha_CloseUp_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 21);
            label1.Name = "label1";
            label1.Size = new Size(140, 32);
            label1.TabIndex = 1;
            label1.Text = "No. Control";
            // 
            // txtNoControl
            // 
            txtNoControl.Location = new Point(30, 60);
            txtNoControl.Name = "txtNoControl";
            txtNoControl.Size = new Size(260, 31);
            txtNoControl.TabIndex = 0;
            txtNoControl.TextChanged += txtNoControl_TextChanged_1;
            txtNoControl.KeyDown += txtNoControl_KeyDown;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.BackgroundColor = SystemColors.ButtonFace;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Columns.AddRange(new DataGridViewColumn[] { Presente });
            dgvAlumnos.Dock = DockStyle.Fill;
            dgvAlumnos.Location = new Point(0, 0);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 62;
            dgvAlumnos.Size = new Size(1223, 514);
            dgvAlumnos.TabIndex = 0;
            dgvAlumnos.CellContentClick += dgvAlumnos_CellContentClick_1;
            // 
            // Presente
            // 
            Presente.HeaderText = "Presente";
            Presente.MinimumWidth = 8;
            Presente.Name = "Presente";
            Presente.Width = 150;
            // 
            // frmAsistencia
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 646);
            Controls.Add(splitContainer1);
            Name = "frmAsistencia";
            Text = "Asistencia";
            Load += frmAsistencia_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DateTimePicker dtpFecha;
        private Label label1;
        private TextBox txtNoControl;
        private DataGridView dgvAlumnos;
        private DataGridViewCheckBoxColumn Presente;
        private Button btnGuardar;
        private Button btnTodos;
    }
}