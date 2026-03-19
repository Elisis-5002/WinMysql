namespace WinMysql.Vistas
{
    partial class frmMaterias
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
            btnAgregarMateria = new Button();
            label1 = new Label();
            txbBuscar = new TextBox();
            dgvMaterias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(btnAgregarMateria);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(txbBuscar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvMaterias);
            splitContainer1.Size = new Size(935, 482);
            splitContainer1.SplitterDistance = 138;
            splitContainer1.TabIndex = 0;
            // 
            // btnAgregarMateria
            // 
            btnAgregarMateria.Location = new Point(765, 46);
            btnAgregarMateria.Name = "btnAgregarMateria";
            btnAgregarMateria.Size = new Size(112, 34);
            btnAgregarMateria.TabIndex = 3;
            btnAgregarMateria.Text = "Agregar";
            btnAgregarMateria.UseVisualStyleBackColor = true;
            btnAgregarMateria.Click += btnAgregarMateria_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 1;
            label1.Text = "Buscar";
            label1.Click += label1_Click;
            // 
            // txbBuscar
            // 
            txbBuscar.Location = new Point(23, 49);
            txbBuscar.Name = "txbBuscar";
            txbBuscar.Size = new Size(727, 31);
            txbBuscar.TabIndex = 0;
            // 
            // dgvMaterias
            // 
            dgvMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterias.Dock = DockStyle.Fill;
            dgvMaterias.Location = new Point(0, 0);
            dgvMaterias.Name = "dgvMaterias";
            dgvMaterias.RowHeadersWidth = 62;
            dgvMaterias.Size = new Size(935, 340);
            dgvMaterias.TabIndex = 0;
            dgvMaterias.CellContentDoubleClick += dgvMaterias_CellContentDoubleClick;
            // 
            // frmMaterias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 482);
            Controls.Add(splitContainer1);
            Name = "frmMaterias";
            Text = "Materias";
            Activated += frmMaterias_Activated;
            Load += frmMaterias_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private TextBox txbBuscar;
        private DataGridView dgvMaterias;
        private Button btnAgregarMateria;
    }
}