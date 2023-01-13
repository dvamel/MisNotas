namespace MisNotas
{
    partial class CrearPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearPersona));
            this.cbxTipos = new System.Windows.Forms.ComboBox();
            this.cbxEstados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ricObservaciones = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.ricDetalle = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ricAplicaciones = new System.Windows.Forms.RichTextBox();
            this.ricContactos = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grpTipoPersonas = new System.Windows.Forms.GroupBox();
            this.rbtCliente = new System.Windows.Forms.RadioButton();
            this.rbtUsuario = new System.Windows.Forms.RadioButton();
            this.grpTipoPersonas.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxTipos
            // 
            this.cbxTipos.FormattingEnabled = true;
            this.cbxTipos.Location = new System.Drawing.Point(12, 108);
            this.cbxTipos.Name = "cbxTipos";
            this.cbxTipos.Size = new System.Drawing.Size(141, 23);
            this.cbxTipos.TabIndex = 0;
            // 
            // cbxEstados
            // 
            this.cbxEstados.FormattingEnabled = true;
            this.cbxEstados.Location = new System.Drawing.Point(12, 152);
            this.cbxEstados.Name = "cbxEstados";
            this.cbxEstados.Size = new System.Drawing.Size(121, 23);
            this.cbxEstados.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(69, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(1002, 23);
            this.txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 617);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Observaciones";
            // 
            // ricObservaciones
            // 
            this.ricObservaciones.Location = new System.Drawing.Point(13, 635);
            this.ricObservaciones.Name = "ricObservaciones";
            this.ricObservaciones.Size = new System.Drawing.Size(339, 65);
            this.ricObservaciones.TabIndex = 7;
            this.ricObservaciones.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(12, 240);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(133, 23);
            this.txtUsuario.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 284);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(130, 23);
            this.txtPassword.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(12, 196);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(316, 23);
            this.txtCorreo.TabIndex = 13;
            // 
            // ricDetalle
            // 
            this.ricDetalle.Location = new System.Drawing.Point(359, 53);
            this.ricDetalle.Name = "ricDetalle";
            this.ricDetalle.Size = new System.Drawing.Size(732, 618);
            this.ricDetalle.TabIndex = 14;
            this.ricDetalle.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(359, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Detalle Tecnico";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 512);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Aplicaciones";
            // 
            // ricAplicaciones
            // 
            this.ricAplicaciones.Location = new System.Drawing.Point(12, 530);
            this.ricAplicaciones.Name = "ricAplicaciones";
            this.ricAplicaciones.Size = new System.Drawing.Size(340, 69);
            this.ricAplicaciones.TabIndex = 17;
            this.ricAplicaciones.Text = "";
            // 
            // ricContactos
            // 
            this.ricContactos.Location = new System.Drawing.Point(12, 337);
            this.ricContactos.Name = "ricContactos";
            this.ricContactos.Size = new System.Drawing.Size(341, 170);
            this.ricContactos.TabIndex = 18;
            this.ricContactos.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Contactos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(848, 677);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(243, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grpTipoPersonas
            // 
            this.grpTipoPersonas.Controls.Add(this.rbtCliente);
            this.grpTipoPersonas.Controls.Add(this.rbtUsuario);
            this.grpTipoPersonas.Location = new System.Drawing.Point(12, 35);
            this.grpTipoPersonas.Name = "grpTipoPersonas";
            this.grpTipoPersonas.Size = new System.Drawing.Size(288, 46);
            this.grpTipoPersonas.TabIndex = 23;
            this.grpTipoPersonas.TabStop = false;
            // 
            // rbtCliente
            // 
            this.rbtCliente.AutoSize = true;
            this.rbtCliente.Location = new System.Drawing.Point(183, 15);
            this.rbtCliente.Name = "rbtCliente";
            this.rbtCliente.Size = new System.Drawing.Size(62, 19);
            this.rbtCliente.TabIndex = 1;
            this.rbtCliente.Text = "Cliente";
            this.rbtCliente.UseVisualStyleBackColor = true;
            // 
            // rbtUsuario
            // 
            this.rbtUsuario.AutoSize = true;
            this.rbtUsuario.Checked = true;
            this.rbtUsuario.Location = new System.Drawing.Point(15, 15);
            this.rbtUsuario.Name = "rbtUsuario";
            this.rbtUsuario.Size = new System.Drawing.Size(65, 19);
            this.rbtUsuario.TabIndex = 0;
            this.rbtUsuario.TabStop = true;
            this.rbtUsuario.Text = "Usuario";
            this.rbtUsuario.UseVisualStyleBackColor = true;
            // 
            // CrearPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 712);
            this.Controls.Add(this.grpTipoPersonas);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ricContactos);
            this.Controls.Add(this.ricAplicaciones);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ricDetalle);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ricObservaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxEstados);
            this.Controls.Add(this.cbxTipos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CrearPersona";
            this.Text = "CrearPersona";
            this.Load += new System.EventHandler(this.CrearPersona_Load);
            this.grpTipoPersonas.ResumeLayout(false);
            this.grpTipoPersonas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTipos;
        private System.Windows.Forms.ComboBox cbxEstados;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private Label label4;
        private RichTextBox ricObservaciones;
        private Label label5;
        private TextBox txtUsuario;
        private Label label6;
        private TextBox txtPassword;
        private Label label7;
        private TextBox txtCorreo;
        private RichTextBox ricDetalle;
        private Label label8;
        private Label label9;
        private RichTextBox ricAplicaciones;
        private RichTextBox ricContactos;
        private Label label10;
        private Button btnGuardar;
        private GroupBox grpTipoPersonas;
        private RadioButton rbtUsuario;
        private RadioButton rbtCliente;
    }
}