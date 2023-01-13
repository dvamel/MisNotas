namespace MisNotas
{
    partial class Pendiente
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdjuntos = new System.Windows.Forms.Button();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ricObservaciones = new System.Windows.Forms.RichTextBox();
            this.lblTituloFecha = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtimeFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtHoraEntrega = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(1016, 710);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Guardar";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(60, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(1031, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titulo";
            // 
            // btnAdjuntos
            // 
            this.btnAdjuntos.Location = new System.Drawing.Point(12, 282);
            this.btnAdjuntos.Name = "btnAdjuntos";
            this.btnAdjuntos.Size = new System.Drawing.Size(241, 22);
            this.btnAdjuntos.TabIndex = 5;
            this.btnAdjuntos.Text = "Agregar Adjuntos";
            this.btnAdjuntos.UseVisualStyleBackColor = true;
            this.btnAdjuntos.Click += new System.EventHandler(this.btnAdjuntos_Click);
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(11, 118);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(242, 23);
            this.cbxEstado.TabIndex = 6;
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(12, 64);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(241, 23);
            this.cbxTipo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo";
            // 
            // ricObservaciones
            // 
            this.ricObservaciones.Location = new System.Drawing.Point(259, 35);
            this.ricObservaciones.Name = "ricObservaciones";
            this.ricObservaciones.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.ricObservaciones.Size = new System.Drawing.Size(842, 669);
            this.ricObservaciones.TabIndex = 10;
            this.ricObservaciones.Text = "";
            // 
            // lblTituloFecha
            // 
            this.lblTituloFecha.AutoSize = true;
            this.lblTituloFecha.Location = new System.Drawing.Point(12, 162);
            this.lblTituloFecha.Name = "lblTituloFecha";
            this.lblTituloFecha.Size = new System.Drawing.Size(98, 15);
            this.lblTituloFecha.TabIndex = 11;
            this.lblTituloFecha.Text = "Fecha De Entrega";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(11, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 404);
            this.panel1.TabIndex = 13;
            this.panel1.Tag = "t";
            // 
            // dtimeFechaEntrega
            // 
            this.dtimeFechaEntrega.Location = new System.Drawing.Point(11, 180);
            this.dtimeFechaEntrega.Name = "dtimeFechaEntrega";
            this.dtimeFechaEntrega.Size = new System.Drawing.Size(242, 23);
            this.dtimeFechaEntrega.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hora De Entrega";
            // 
            // dtHoraEntrega
            // 
            this.dtHoraEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraEntrega.Location = new System.Drawing.Point(12, 243);
            this.dtHoraEntrega.Name = "dtHoraEntrega";
            this.dtHoraEntrega.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtHoraEntrega.ShowUpDown = true;
            this.dtHoraEntrega.Size = new System.Drawing.Size(117, 23);
            this.dtHoraEntrega.TabIndex = 13;
            // 
            // Pendiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 736);
            this.Controls.Add(this.btnAdjuntos);
            this.Controls.Add(this.dtimeFechaEntrega);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ricObservaciones);
            this.Controls.Add(this.dtHoraEntrega);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.lblTituloFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Pendiente";
            this.Tag = "";
            this.Text = "Pendiente";
            this.Load += new System.EventHandler(this.Pendiente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCrear;
        private Button btnEditar;
        private TextBox txtNombre;
        private Label label1;
        private Button btnAdjuntos;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.ComboBox cbxTipo;
        private Label label2;
        private Label label3;
        private RichTextBox ricObservaciones;
        private Label lblTituloFecha;
        public Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private DateTimePicker dtimeFechaEntrega;
        private DateTimePicker dtHoraEntrega;
    }
}