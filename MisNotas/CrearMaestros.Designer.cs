namespace MisNotas
{
    partial class CrearMaestros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearMaestros));
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dGridDatos = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grpVisible = new System.Windows.Forms.GroupBox();
            this.rbtVisibleNo = new System.Windows.Forms.RadioButton();
            this.rbtVisibleSi = new System.Windows.Forms.RadioButton();
            this.gblistados = new System.Windows.Forms.GroupBox();
            this.rbNoListados = new System.Windows.Forms.RadioButton();
            this.rbSIListados = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGridDatos)).BeginInit();
            this.grpVisible.SuspendLayout();
            this.gblistados.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(49, 245);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(163, 245);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(3, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(256, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(11, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(50, 20);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "label1";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dGridDatos
            // 
            this.dGridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridDatos.Location = new System.Drawing.Point(289, 32);
            this.dGridDatos.Name = "dGridDatos";
            this.dGridDatos.RowTemplate.Height = 25;
            this.dGridDatos.Size = new System.Drawing.Size(473, 410);
            this.dGridDatos.TabIndex = 5;
            this.dGridDatos.Click += new System.EventHandler(this.dGridDatos_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(2, 77);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(126, 23);
            this.txtCodigo.TabIndex = 6;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(3, 60);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 15);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Codigo";
            // 
            // grpVisible
            // 
            this.grpVisible.Controls.Add(this.rbtVisibleNo);
            this.grpVisible.Controls.Add(this.rbtVisibleSi);
            this.grpVisible.Location = new System.Drawing.Point(5, 106);
            this.grpVisible.Name = "grpVisible";
            this.grpVisible.Size = new System.Drawing.Size(124, 50);
            this.grpVisible.TabIndex = 24;
            this.grpVisible.TabStop = false;
            this.grpVisible.Text = "Visible";
            // 
            // rbtVisibleNo
            // 
            this.rbtVisibleNo.AutoSize = true;
            this.rbtVisibleNo.Location = new System.Drawing.Point(64, 15);
            this.rbtVisibleNo.Name = "rbtVisibleNo";
            this.rbtVisibleNo.Size = new System.Drawing.Size(41, 19);
            this.rbtVisibleNo.TabIndex = 1;
            this.rbtVisibleNo.Text = "No";
            this.rbtVisibleNo.UseVisualStyleBackColor = true;
            // 
            // rbtVisibleSi
            // 
            this.rbtVisibleSi.AutoSize = true;
            this.rbtVisibleSi.Checked = true;
            this.rbtVisibleSi.Location = new System.Drawing.Point(6, 15);
            this.rbtVisibleSi.Name = "rbtVisibleSi";
            this.rbtVisibleSi.Size = new System.Drawing.Size(34, 19);
            this.rbtVisibleSi.TabIndex = 0;
            this.rbtVisibleSi.TabStop = true;
            this.rbtVisibleSi.Text = "Si";
            this.rbtVisibleSi.UseVisualStyleBackColor = true;
            // 
            // gblistados
            // 
            this.gblistados.Controls.Add(this.rbNoListados);
            this.gblistados.Controls.Add(this.rbSIListados);
            this.gblistados.Location = new System.Drawing.Point(135, 63);
            this.gblistados.Name = "gblistados";
            this.gblistados.Size = new System.Drawing.Size(124, 51);
            this.gblistados.TabIndex = 25;
            this.gblistados.TabStop = false;
            this.gblistados.Text = "Incluir En Listados";
            // 
            // rbNoListados
            // 
            this.rbNoListados.AutoSize = true;
            this.rbNoListados.Location = new System.Drawing.Point(64, 15);
            this.rbNoListados.Name = "rbNoListados";
            this.rbNoListados.Size = new System.Drawing.Size(41, 19);
            this.rbNoListados.TabIndex = 1;
            this.rbNoListados.Text = "No";
            this.rbNoListados.UseVisualStyleBackColor = true;
            // 
            // rbSIListados
            // 
            this.rbSIListados.AutoSize = true;
            this.rbSIListados.Checked = true;
            this.rbSIListados.Location = new System.Drawing.Point(6, 15);
            this.rbSIListados.Name = "rbSIListados";
            this.rbSIListados.Size = new System.Drawing.Size(34, 19);
            this.rbSIListados.TabIndex = 0;
            this.rbSIListados.TabStop = true;
            this.rbSIListados.Text = "Si";
            this.rbSIListados.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.cbxCategoria);
            this.panel1.Controls.Add(this.gblistados);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grpVisible);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.lblCodigo);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(271, 207);
            this.panel1.TabIndex = 25;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(5, 177);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(158, 23);
            this.cbxCategoria.TabIndex = 26;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(5, 160);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(58, 15);
            this.lblCategoria.TabIndex = 27;
            this.lblCategoria.Text = "Categoria";
            // 
            // CrearMaestros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dGridDatos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCrear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CrearMaestros";
            this.Text = "CrearMaestros";
            ((System.ComponentModel.ISupportInitialize)(this.dGridDatos)).EndInit();
            this.grpVisible.ResumeLayout(false);
            this.grpVisible.PerformLayout();
            this.gblistados.ResumeLayout(false);
            this.gblistados.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCrear;
        private Button btnEditar;
        private TextBox txtNombre;
        private Label lblTitulo;
        private DataGridView dGridDatos;
        private TextBox txtCodigo;
        private Label label1;
        private Label lblCodigo;
        private GroupBox grpVisible;
        private RadioButton rbtVisibleNo;
        private RadioButton rbtVisibleSi;
        private Panel panel1;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton rbNoListados;
        private RadioButton rbSIListados;
        private GroupBox gblistados;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private Label lblCategoria;
    }
}