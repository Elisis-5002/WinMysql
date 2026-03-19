namespace WinMysql.Vistas
{
    partial class frmAgregarAlum
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
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPaterno = new TextBox();
            label3 = new Label();
            txtMaterno = new TextBox();
            label4 = new Label();
            txtNoControl = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(43, 245);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(213, 31);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 206);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 206);
            label2.Name = "label2";
            label2.Size = new Size(143, 25);
            label2.TabIndex = 3;
            label2.Text = "Apellido Paterno";
            // 
            // txtPaterno
            // 
            txtPaterno.Location = new Point(288, 245);
            txtPaterno.Name = "txtPaterno";
            txtPaterno.Size = new Size(213, 31);
            txtPaterno.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(534, 206);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 5;
            label3.Text = "Apellido Materno";
            // 
            // txtMaterno
            // 
            txtMaterno.Location = new Point(534, 245);
            txtMaterno.Name = "txtMaterno";
            txtMaterno.Size = new Size(213, 31);
            txtMaterno.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 19);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 7;
            label4.Text = "No. de Control";
            // 
            // txtNoControl
            // 
            txtNoControl.Location = new Point(43, 58);
            txtNoControl.Name = "txtNoControl";
            txtNoControl.Size = new Size(213, 31);
            txtNoControl.TabIndex = 6;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(622, 56);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 34);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmAgregarAlum
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(label4);
            Controls.Add(txtNoControl);
            Controls.Add(label3);
            Controls.Add(txtMaterno);
            Controls.Add(label2);
            Controls.Add(txtPaterno);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "frmAgregarAlum";
            Text = "Alumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtPaterno;
        private Label label3;
        private TextBox txtMaterno;
        private Label label4;
        private TextBox txtNoControl;
        private Button btnAceptar;
    }
}