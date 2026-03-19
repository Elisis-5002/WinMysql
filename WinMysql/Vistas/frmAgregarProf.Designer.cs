namespace WinMysql.Vistas
{
    partial class frmAgregarProf
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
            txtNombre = new TextBox();
            txtPaterno = new TextBox();
            label2 = new Label();
            txtMaterno = new TextBox();
            label3 = new Label();
            txtCedProf = new TextBox();
            label4 = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(21, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 31);
            txtNombre.TabIndex = 1;
            // 
            // txtPaterno
            // 
            txtPaterno.Location = new Point(273, 42);
            txtPaterno.Name = "txtPaterno";
            txtPaterno.Size = new Size(228, 31);
            txtPaterno.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 9);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 2;
            label2.Text = "Apellido Paterno";
            // 
            // txtMaterno
            // 
            txtMaterno.Location = new Point(525, 42);
            txtMaterno.Name = "txtMaterno";
            txtMaterno.Size = new Size(228, 31);
            txtMaterno.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(528, 9);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 4;
            label3.Text = "Apellido Materno";
            // 
            // txtCedProf
            // 
            txtCedProf.Location = new Point(24, 190);
            txtCedProf.Name = "txtCedProf";
            txtCedProf.Size = new Size(228, 31);
            txtCedProf.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 157);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 6;
            label4.Text = "Cedula Profesional";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(641, 187);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 34);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmAgregarProf
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(txtCedProf);
            Controls.Add(label4);
            Controls.Add(txtMaterno);
            Controls.Add(label3);
            Controls.Add(txtPaterno);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "frmAgregarProf";
            Text = "Profesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtPaterno;
        private Label label2;
        private TextBox txtMaterno;
        private Label label3;
        private TextBox txtCedProf;
        private Label label4;
        private Button btnAceptar;
    }
}