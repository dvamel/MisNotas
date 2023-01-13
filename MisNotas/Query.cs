namespace MisNotas
{
    public partial class Query : Form
    {
        ComboBox cm = new ComboBox();
        public int Id = 0;
        public Query()
        {
            InitializeComponent();
            cargarCombox();
            
        }

        public Query(int id)
        {

            InitializeComponent();
            consultarQuery(id);
            Id = id;
           


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())
            {
                MessageBox.Show("Datos no validos");
                return;

            }
            else
            {
                IngresarQuerys();

                this.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            IngresarQuerys();
        }

        public void cargarCombox()
        {


            cm.Tipo = 4;
            cbxTipo.DataSource = cm.CargarCombo("listados");
            cbxTipo.DisplayMember = "Nombre";
            cbxTipo.ValueMember = "Id";

            cm.Tipo = 2;
            cbxEstado.DataSource = cm.CargarCombo("listados");
            cbxEstado.DisplayMember = "Nombre";
            cbxEstado.ValueMember = "Id";

            cm.Tipo = 11;
            cbxCreadora.DataSource = cm.CargarCombo("listados");
            cbxCreadora.DisplayMember = "Nombre";
            cbxCreadora.ValueMember = "Id";
        }

        public bool ValidarDatos()
        {
            if (txtNombre.Text == "")
                return false;

            return true;
        }

        public void IngresarQuerys()
        {
            try
            {

                CrearQuery cq = new CrearQuery();

                if (Id > 0)
                    cq.Id = Id;

                cq.TipoId = Int32.Parse(cbxTipo.SelectedValue.ToString());
                cq.EstadoId = Int32.Parse(cbxEstado.SelectedValue.ToString());
                cq.PersonaId = Int32.Parse(cbxCreadora.SelectedValue.ToString());
                cq.Nombre = txtNombre.Text;
                cq.Observaciones = richObservaciones.Text;
                cq.DetalleTecnico = richDetalleTecnico.Text;
                cq.Aplicaciones = richAplicaciones.Text;

                if (!cq.ValidarDatos())
                {
                    MessageBox.Show(cq.MensajeDeError);
                    return;
                }



                cq.IngresarQuery();
                if (Id > 0)
                {

                    Id = cq.Id;
                    PanelPrincipal pp = Owner as PanelPrincipal;
                    pp.listarPendientes();
                    

                }

                this.Close();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }


        public void consultarQuery(int id)
        {

            txtNombre.Enabled = false;
           
            cargarCombox();

            try
            {

                CrearQuery cq = new CrearQuery();
                cq.Tipo = 12;
                cq.Id = id;
                cq.ConsultarQueryPorId();
                txtNombre.Text = cq.Nombre;
                cbxTipo.SelectedValue = cq.TipoId;
                cbxEstado.SelectedValue = cq.EstadoId;
                cbxCreadora.SelectedValue = cq.PersonaId;
                richDetalleTecnico.Text = cq.DetalleTecnico;
                richAplicaciones.Text = cq.Aplicaciones;
                richObservaciones.Text = cq.Observaciones;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void Query_Load(object sender, EventArgs e)
        {

        }
    }
}
