namespace MisNotas
{
    public partial class Adjunto : Form
    {
        private int Id=0;
        public Adjunto()
        {
            InitializeComponent();
        }

        public Adjunto(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "D:\\OneDrive\\Documents";
            openFileDialog1.Filter = "Todos los archivos (*.*) |*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtRuta.Text = openFileDialog1.FileName;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] archivo = null;
                Stream MySteam = openFileDialog1.OpenFile();
                MemoryStream obj = new MemoryStream();
                MySteam.CopyTo(obj);
                archivo = obj.ToArray();


                CrearAdjuntos aj = new CrearAdjuntos();
                aj.Nombre = txtTitulo.Text;
                aj.Ruta = openFileDialog1.SafeFileName;
                aj.Fecha = DateTime.Now;
                aj.Observaciones = rchObservaciones.Text;
                aj.TipoId = 1;
                aj.Documento = archivo;

                aj.IngresarAdjuntos();

                if (Id > 0)
                {
                    aj.Tipo = 1;
                    aj.DocuementoId = aj.Id;
                    aj.RelacionId = Id;
                    aj.IngresarRelacionAdjuntos();
                    Pendiente p = Owner as Pendiente;
                    p.panel1.Controls.Clear();
                    p.Top = 33;
                    p.Left = 8;
                    p.listarAdjuntosDePendientes();


                }
                

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
    }
}
