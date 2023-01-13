namespace MisNotas
{
    public partial class CrearPersona : Form
    {
        private int pTipo;
        ComboBox cm = new ComboBox();
        public CrearPersona()
        {
            InitializeComponent();
        }

        public CrearPersona(int id)
        {
            InitializeComponent();
            consultaPersona(id);
        }
        
        private void CrearPersona_Load(object sender, EventArgs e)
        {
            cargarCombox();
           
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
                IngresarPersona();
            }

            this.Close();
        }

        public bool ValidarDatos()
        {
            if (txtNombre.Text != "" || txtNombre.Text.Count() < 50)
                return true;


            else if (ricObservaciones.Text.Count() < 1000)
                return true;

            else if (txtUsuario.Text.Count() < 20)
                return true;

            else if (txtCorreo.Text.Count() < 200)
                return true;


            return false;
        }

        private void IngresarPersona()
        {
            try
            {
                if (rbtCliente.Checked == true)
                    pTipo = 2;

                if (rbtUsuario.Checked == true)
                    pTipo = 1;

                Personas pe = new Personas();
                pe.Tipo = pTipo;
                pe.TipoId = Int32.Parse(cbxTipos.SelectedValue.ToString());
                pe.EstadoId = Int32.Parse(cbxEstados.SelectedValue.ToString());
                pe.Nombre = txtNombre.Text;
                pe.Observaciones = ricObservaciones.Text;
                pe.NombreUsuario = txtUsuario.Text;
                pe.Password = txtPassword.Text;
                pe.Activo = true;
                pe.Correo = txtCorreo.Text;
                pe.DetalleTecnico = ricDetalle.Text;
                pe.Aplicaciones = ricAplicaciones.Text;
                pe.Contactos = ricContactos.Text;


                if (!pe.ValidarDatos())
                {
                    MessageBox.Show(pe.MensajeDeError);
                    return;
                }



                pe.CrearMaestro();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }


        public void cargarCombox()
        {


            cm.Tipo = 1;
            cbxTipos.DataSource = cm.CargarCombo("listados");
            cbxTipos.DisplayMember = "Nombre";
            cbxTipos.ValueMember = "Id";

            cm.Tipo = 2;
            cbxEstados.DataSource = cm.CargarCombo("listados");
            cbxEstados.DisplayMember = "Nombre";
            cbxEstados.ValueMember = "Id";


        }

        public void consultaPersona(int id)
        {


            cargarCombox();
            grpTipoPersonas.Visible = false;

            try
            {

                Personas pe = new Personas();
                pe.Tipo = 14;
                pe.Id = id;
                pe.ConsultarPersonaPorId();
                pe.TipoId = Int32.Parse(cbxTipos.SelectedValue.ToString());
                pe.EstadoId = Int32.Parse(cbxEstados.SelectedValue.ToString());
                txtNombre.Text=pe.Nombre;
                ricObservaciones.Text=pe.Observaciones;
                txtUsuario.Text=pe.NombreUsuario;
                txtPassword.Text=pe.Password;
                txtCorreo.Text=pe.Correo;
                ricDetalle.Text=pe.DetalleTecnico;
                ricAplicaciones.Text=pe.Aplicaciones;
                ricContactos.Text=pe.Contactos;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
    }
}
