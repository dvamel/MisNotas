namespace MisNotas
{
    public partial class CrearMaestros : Form
    {
        private int pTipo;
        private bool Visible;
        private bool IncluirEnListados;
        Maestros me = new Maestros();
        ComboBox cm = new ComboBox();
        public CrearMaestros()
        {
            
        }

        public CrearMaestros(string Titulo, int Tipo)
        {
            
            InitializeComponent();
            cargarCombox();
            lblTitulo.Text = Titulo.ToString();
            pTipo = Tipo;


            me.Tipo = Tipo;
            dGridDatos.DataSource = me.ListarMaestros();

            for (var i = 0; i < dGridDatos.Columns.Count; i++)
            {
                dGridDatos.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dGridDatos.Columns[i].ReadOnly = true;
            }
            btnEditar.Enabled = false;

            if (pTipo != 6)
            {

                gblistados.Visible = false;

            }
            else
            {
                grpVisible.Visible = false;
                txtCodigo.Visible = false;
                lblCodigo.Visible = false;
                lblCategoria.Visible = false;
                cbxCategoria.Visible = false;
                

            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                MessageBox.Show("Datos no validos");
                return;

            }
            else
            {
                CrearMaestro(pTipo, txtNombre.Text, txtCodigo.Text);
                dGridDatos.DataSource = me.ListarMaestros();
                txtCodigo.Clear();
                txtNombre.Clear();
                rbtVisibleNo.Checked = false;
                rbtVisibleSi.Checked = true;
                rbNoListados.Checked = false;
                rbSIListados.Checked = true;
            }



        }

        private void CrearMaestro(int Tipo, string Nombre, string codigo)
        {
            try
            {
                if (rbtVisibleSi.Checked == true)
                    Visible = true;

                if (rbtVisibleNo.Checked == true)
                    Visible = false;

                if (rbSIListados.Checked == true)
                    IncluirEnListados = true;

                if (rbNoListados.Checked == true)
                    IncluirEnListados = false;


                me.Tipo = Tipo;
                me.Nombre = Nombre;
                me.Codigo = codigo;
                me.Visible = Visible;
                me.IncluirEnListados = IncluirEnListados;
                if(Tipo!=6)
                   me.CategoriaId = Int32.Parse(cbxCategoria.SelectedValue.ToString());

                if (!me.ValidarDatos())
                {
                    MessageBox.Show(me.MensajeDeError);
                    return;
                }



                me.CrearMaestro();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private bool ValidarDatos()
        {
            if (pTipo != 6)
                if (txtNombre.Text.ToString() == "" || txtCodigo.Text.ToString() == "")
                    return false;

            return true;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            //    (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //    MessageBox.Show("Solo números");
            //}


            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void dGridDatos_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            btnCrear.Enabled = false;
            txtCodigo.Enabled = false;
            txtNombre.Text = dGridDatos.CurrentRow.Cells[1].Value.ToString();
            if (pTipo != 6) 
                txtCodigo.Text = dGridDatos.CurrentRow.Cells[2].Value.ToString();


            if (pTipo != 6)
            {
                if (dGridDatos.CurrentRow.Cells[3].Value.ToString() == "True")
                {
                    rbtVisibleSi.Checked = true;
                    rbtVisibleNo.Checked = false;

                }
                else
                {

                    rbtVisibleSi.Checked = false;
                    rbtVisibleNo.Checked = true;
                }
                cbxCategoria.SelectedValue=dGridDatos.CurrentRow.Cells[4].Value.ToString();
            }
            else
            {
                if (dGridDatos.CurrentRow.Cells[2].Value.ToString() == "True")
                {
                    rbSIListados.Checked = true;
                    rbNoListados.Checked = false;

                }
                else
                {

                    rbSIListados.Checked = false;
                    rbNoListados.Checked = true;
                }
                

            }
            
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                MessageBox.Show("Datos no validos");
                return;

            }
            else
            {
                CrearMaestro(pTipo, txtNombre.Text, txtCodigo.Text);
                dGridDatos.DataSource = me.ListarMaestros();
                txtCodigo.Clear();
                txtNombre.Clear();
                rbtVisibleNo.Checked = false;
                rbtVisibleSi.Checked = true;
            }

        }

        public void cargarCombox()
        {


            cm.Tipo = 13;
            cbxCategoria.DataSource = cm.CargarCombo("listados");
            cbxCategoria.DisplayMember = "Nombre";
            cbxCategoria.ValueMember = "Id";

     
        }

    }
}
