namespace MisNotas
{
    partial class Query
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Query));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.richDetalleTecnico = new System.Windows.Forms.RichTextBox();
            this.richAplicaciones = new System.Windows.Forms.RichTextBox();
            this.richObservaciones = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCreadora = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Aplicaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "Detalle tecnico";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(87, 606);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(170, 23);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // richDetalleTecnico
            // 
            this.richDetalleTecnico.Location = new System.Drawing.Point(12, 159);
            this.richDetalleTecnico.Name = "richDetalleTecnico";
            this.richDetalleTecnico.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richDetalleTecnico.Size = new System.Drawing.Size(377, 229);
            this.richDetalleTecnico.TabIndex = 36;
            this.richDetalleTecnico.Text = "";
            // 
            // richAplicaciones
            // 
            this.richAplicaciones.Location = new System.Drawing.Point(12, 437);
            this.richAplicaciones.Name = "richAplicaciones";
            this.richAplicaciones.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richAplicaciones.Size = new System.Drawing.Size(377, 131);
            this.richAplicaciones.TabIndex = 35;
            this.richAplicaciones.Text = "";
            // 
            // richObservaciones
            // 
            this.richObservaciones.Location = new System.Drawing.Point(395, 36);
            this.richObservaciones.Name = "richObservaciones";
            this.richObservaciones.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richObservaciones.Size = new System.Drawing.Size(760, 718);
            this.richObservaciones.TabIndex = 34;
            this.richObservaciones.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Persona Creadora";
            // 
            // cbxCreadora
            // 
            this.cbxCreadora.FormattingEnabled = true;
            this.cbxCreadora.Location = new System.Drawing.Point(118, 42);
            this.cbxCreadora.Name = "cbxCreadora";
            this.cbxCreadora.Size = new System.Drawing.Size(250, 23);
            this.cbxCreadora.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(69, 7);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(800, 23);
            this.txtNombre.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tipo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Estado";
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(118, 99);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(139, 23);
            this.cbxTipo.TabIndex = 27;
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(118, 69);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(139, 23);
            this.cbxEstado.TabIndex = 26;
            // 
            // Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 766);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.richDetalleTecnico);
            this.Controls.Add(this.richAplicaciones);
            this.Controls.Add(this.richObservaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxCreadora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.cbxEstado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Query";
            this.Text = "Query";
            this.Load += new System.EventHandler(this.Query_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label6;
        private Label label5;
        private Button btnGuardar;
        private RichTextBox richDetalleTecnico;
        private RichTextBox richAplicaciones;
        private RichTextBox richObservaciones;
        private Label label4;
        private System.Windows.Forms.ComboBox cbxCreadora;
        private Label label1;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.ComboBox cbxEstado;
    }
}