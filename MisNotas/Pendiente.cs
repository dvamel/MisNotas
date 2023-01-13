using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MisNotas
{
    public partial class Pendiente : Form
    {
        ComboBox cm = new ComboBox();
        public int Id =0;
        public int IdAdjunto =0;
        public int Top = 33;
        public int Left = 8;
        public Pendiente()
        {
            InitializeComponent();
            cargarCombox();
            
             
            
        }
        public Pendiente(int id)
        {
            
            InitializeComponent();
            consultaPendiente(id);
            Id = id;
            listarAdjuntosDePendientes();
           

        }




        private void Pendiente_Load(object sender, EventArgs e)
        {
            
          
            
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
                IngresarPendiente();
                this.Close();
            }
        }

        public bool ValidarDatos()
        {
            if (txtNombre.Text == "" || ricObservaciones.Text == "")
                return false;

            return true;
        }

        private void IngresarPendiente()
        {
            crearpendientes();
            crearDetalleDeAdjunto();
        }

        private void btnAdjuntos_Click(object sender, EventArgs e)
        {
            Adjunto frm = new Adjunto(Id);
            AddOwnedForm(frm);
            frm.StartPosition = FormStartPosition.CenterScreen;
            
            frm.Show();
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           crearpendientes();
        }

        private void ConsultaAdjunto_Click(object sender, EventArgs e)
        {

            consultarAdjunto(sender, e);
        }


        public void cargarCombox()
        {

            
            cm.Tipo = 5;
            cbxTipo.DataSource = cm.CargarCombo("listados");
            cbxTipo.DisplayMember = "Nombre";
            cbxTipo.ValueMember = "Id";

            cm.Tipo = 2;
            cbxEstado.DataSource = cm.CargarCombo("listados");
            cbxEstado.DisplayMember = "Nombre";
            cbxEstado.ValueMember = "Id";
        }

        public void consultaPendiente(int id)
        {

            txtNombre.Enabled = false;
            
            cargarCombox();

            try
            {

                CrearPendientes pe = new CrearPendientes();
                pe.Tipo = 9;
                pe.Id = id;
                pe.ConsultarPendientePorId();
                txtNombre.Text = pe.Nombre;
                cbxTipo.SelectedValue =pe.TipoId;
                cbxEstado.SelectedValue = pe.EstadoId;
                dtimeFechaEntrega.Value = pe.FechaDeEntrega;
                ricObservaciones.Text = pe.Observaciones;
                dtHoraEntrega.Value = pe.HoraDeEntrega;
          


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

      
        public void crearpendientes()
        {
            try
            {

                CrearPendientes pe = new CrearPendientes();

                if(Id > 0)
                    pe.Id = Id;

                pe.TipoId = Int32.Parse(cbxTipo.SelectedValue.ToString());
                pe.EstadoId = Int32.Parse(cbxEstado.SelectedValue.ToString());
                pe.Nombre = txtNombre.Text;
                pe.Observaciones = ricObservaciones.Text;
                pe.Fecha = DateTime.Now;
                pe.FechaDeEntrega = DateTime.Parse(dtimeFechaEntrega.Value.ToShortDateString());
                pe.HoraDeEntrega = DateTime.Parse(dtHoraEntrega.Value.ToShortTimeString());

                if (!pe.ValidarDatos())
                {
                    MessageBox.Show(pe.MensajeDeError);
                    return;
                }



                pe.IngresarPendientes();
                Id = pe.Id;
                PanelPrincipal pp = Owner as PanelPrincipal;
                pp.listarPendientes();
                this.Close();

               



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

        }


        public void listarAdjuntosDePendientes()
        {
            
            CrearAdjuntos cp = new CrearAdjuntos();
            DataSet ds = new DataSet();
            cp.Tipo = 10;

            if(Id >0)
               cp.Id = Id;


            ds = cp.ConsultarListadoAdjuntosEnTablaPorId();


            if (ds.Tables[0].Rows.Count > 0)
            {


                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    LinkLabel linkLabel1 = new LinkLabel();
                    panel1.Controls.Add(linkLabel1);
                    linkLabel1.AutoSize = true;
                    linkLabel1.Location = new System.Drawing.Point(Left, Top); // 8,33
                    linkLabel1.Name = "linkLabel" + ds.Tables[0].Rows[i]["Id"].ToString();
                    linkLabel1.Size = new System.Drawing.Size(70, 19);
                    linkLabel1.TabIndex = (int)ds.Tables[0].Rows[i]["Id"];
                    linkLabel1.TabStop = true;
                    linkLabel1.Text = i + ". " + ds.Tables[0].Rows[i]["Nombre"].ToString();
                    linkLabel1.LinkColor = Color.Blue;
                    linkLabel1.Click += (sender, EventArgs) => ConsultaAdjunto_Click(sender, EventArgs); ;
                    linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    Top += 25;


                }

            }
        }

        public void listarAdjuntosDePendientesPorAdjuntos()
        {
            CrearAdjuntos cp = new CrearAdjuntos();
            DataSet ds = new DataSet();
            cp.Tipo = 7;
          
                cp.Id = IdAdjunto;


            ds = cp.ConsultarListadoAdjuntosEnTablaPorId();


            if (ds.Tables[0].Rows.Count > 0)
            {


                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    LinkLabel linkLabel1 = new LinkLabel();
                    panel1.Controls.Add(linkLabel1);
                    linkLabel1.AutoSize = true;
                    linkLabel1.Location = new System.Drawing.Point(Left, Top); // 8,33
                    linkLabel1.Name = "linkLabel" + ds.Tables[0].Rows[i]["Id"].ToString();
                    linkLabel1.Size = new System.Drawing.Size(70, 19);
                    linkLabel1.TabIndex = (int)ds.Tables[0].Rows[i]["Id"];
                    linkLabel1.TabStop = true;
                    linkLabel1.Text = i + ". " + ds.Tables[0].Rows[i]["Nombre"].ToString();
                    linkLabel1.LinkColor = Color.Blue;
                    linkLabel1.Click += (sender, EventArgs) => ConsultaAdjunto_Click(sender, EventArgs); ;
                    linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    Top += 25;


                }

            }
        }

        public void consultarAdjunto(object sender, EventArgs e)
        {
            LinkLabel tb = (LinkLabel)sender;
            CrearAdjuntos cp = new CrearAdjuntos();
            DataSet ds = new DataSet();
            cp.Tipo = 7;
            cp.Id = tb.TabIndex;
            ds = cp.ConsultarListadoAdjuntosEnTablaPorId();


            if (ds.Tables[0].Rows.Count > 0)
            {


                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    string direccion = AppDomain.CurrentDomain.BaseDirectory;
                    string carpeta = direccion + @"temp\";
                    string ubicacionCompleta = carpeta + ds.Tables[0].Rows[i]["Ruta"].ToString();

                    if (!Directory.Exists(carpeta))
                        Directory.CreateDirectory(carpeta);

                    if (File.Exists(ubicacionCompleta))
                        File.Delete(ubicacionCompleta);

                    File.WriteAllBytes(ubicacionCompleta, (byte[])ds.Tables[0].Rows[i]["Documento"]);
                    Process.Start(new ProcessStartInfo(ubicacionCompleta) { UseShellExecute = true });



                }

            }

        }

        public void crearDetalleDeAdjunto()
        {

            if (Id > 0)
            {

                CrearAdjuntos aj = new CrearAdjuntos();
                aj.Tipo = 1;
                aj.DocuementoId =IdAdjunto;
                aj.RelacionId = Id;
                aj.IngresarRelacionAdjuntos();
            }
        }

        public void LimpiarAdjuntos()
        {

            panel1.Controls.Clear();
        }
    }
}
