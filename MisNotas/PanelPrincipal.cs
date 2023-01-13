using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace MisNotas
{
    public partial class PanelPrincipal : Form
    {
       

        private int Top = 33;
        private int Top2 = 50;
        private int Left = 8;
        private int id;
       

        public PanelPrincipal()
        {
            InitializeComponent();
            autoCompletar();
            listarPendientes();
           

        }


        private void PanelPrincipal_Load(object sender, EventArgs e)
        {
           
          
            
        }
        private void btnPersonas_Click(object sender, EventArgs e)
        {
            CrearPersona frm = new CrearPersona();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
        private void btnEstados_Click(object sender, EventArgs e)
        {
            CrearMaestros frm = new CrearMaestros("Administrador De Estados",2);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void btnTiposDePersonas_Click(object sender, EventArgs e)
        {
            CrearMaestros frm = new CrearMaestros("Administrador De Tipos De Personas",1);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void btnTiposDeAdjuntos_Click(object sender, EventArgs e)
        {
            CrearMaestros frm = new CrearMaestros("Administrador De Tipos De Adjuntos",3);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void btnTiposDeQuerys_Click(object sender, EventArgs e)
        {
            CrearMaestros frm = new CrearMaestros("Administrador De Tipos De Querys",4);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void btnTiposDePendientes_Click(object sender, EventArgs e)
        {
            CrearMaestros frm = new CrearMaestros("Administrador De Tipos De Pendientes",5);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void btnPendiente_Click(object sender, EventArgs e)
        {
          
            Pendiente frm = new Pendiente();
            AddOwnedForm(frm);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            
           
           
            
        }
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            CrearMaestros frm = new CrearMaestros("Administrador De Categorias", 6);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }


        private void btnQuery_Click(object sender, EventArgs e)
        {


            Query frm = new Query();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();




        }

        private void btnAdjunto_Click(object sender, EventArgs e)
        {
            Adjunto frm = new Adjunto();
            AddOwnedForm(frm);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            
        }




        /// <summary>
        /// Metodos
        /// </summary>

        private void ConsultaAdjunto_Click(object sender, EventArgs e)
        {
            
                consultarAdjunto(sender,e);
        }

        private void ListarResultadoGeneral_Click(object sender, EventArgs e)
        {

            consultarAdjunto(sender, e);
        }


        private void ConsultaPendientes_Click(object sender, EventArgs e)
        {

            LinkLabel tb = (LinkLabel)sender;
            Pendiente frm = new Pendiente(tb.TabIndex);
            AddOwnedForm(frm);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void ConsultaQuery_Click(object sender, EventArgs e)
        {
            LinkLabel tb = (LinkLabel)sender;
            Query frm = new Query(tb.TabIndex);
            AddOwnedForm(frm);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();

        }

        private void ConsultaPersonas_Click(object sender, EventArgs e)
        {
            LinkLabel tb = (LinkLabel)sender;
            CrearPersona frm = new CrearPersona(tb.TabIndex);
            AddOwnedForm(frm);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }



        /// <summary>
        /// Metodos
        /// </summary>

        public void listarPendientes()
        {



            panel2.Controls.Clear();
            Top = 33;
            CrearPendientes cp = new CrearPendientes();
            DataSet ds = new DataSet();
            cp.Tipo = 6;
            ds = cp.ConsultarListadoPendiente();


            if (ds.Tables[0].Rows.Count > 0)
            {


                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    LinkLabel linkLabel1 = new LinkLabel();
                    panel2.Controls.Add(linkLabel1);
                    linkLabel1.AutoSize = true;
                    linkLabel1.Location = new System.Drawing.Point(Left, Top); // 8,33
                    linkLabel1.Name = "linkLabel" + ds.Tables[0].Rows[i]["Id"].ToString();
                    linkLabel1.Size = new System.Drawing.Size(233, 15);
                    linkLabel1.TabIndex = (int)ds.Tables[0].Rows[i]["Id"];
                    linkLabel1.TabStop = true;
                    linkLabel1.Text = i + ". " + ds.Tables[0].Rows[i]["Nombre"].ToString();
                    linkLabel1.LinkColor = System.Drawing.ColorTranslator.FromHtml((ds.Tables[0].Rows[i]["Color"].ToString()));
                    linkLabel1.Click += new System.EventHandler(ConsultaPendientes_Click);
                    Top += 25;


                }

            }


        }

        public void listarAdjuntos()
        {



            panel3.Controls.Clear();
            Top = 33;
            CrearAdjuntos cp = new CrearAdjuntos();
            DataSet ds = new DataSet();
            cp.Tipo = 7;
            ds = cp.ConsultarListadoAdjuntos();


            if (ds.Tables[0].Rows.Count > 0)
            {


                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    LinkLabel linkLabel1 = new LinkLabel();
                    panel3.Controls.Add(linkLabel1);
                    linkLabel1.AutoSize = true;
                    linkLabel1.Location = new System.Drawing.Point(Left, Top); // 8,33
                    linkLabel1.Name = "linkLabel" + ds.Tables[0].Rows[i]["Id"].ToString();
                    linkLabel1.Size = new System.Drawing.Size(233, 15);
                    linkLabel1.TabIndex = (int)ds.Tables[0].Rows[i]["Id"];
                    linkLabel1.TabStop = true;
                    linkLabel1.Text = i + ". " + ds.Tables[0].Rows[i]["Nombre"].ToString();
                    linkLabel1.LinkColor = Color.Blue;
                    linkLabel1.Click += (sender, EventArgs) => ConsultaAdjunto_Click(sender, EventArgs); ;
                    Top += 25;


                }

            }


        }

        public void listarResultadoGeneral(string nombre)
        {



            panel3.Controls.Clear();
            Top = 33;
            Top2 = 58;
            ComboBox cb = new ComboBox();
            DataSet ds = new DataSet();
            cb.Tipo = 8;
            cb.Nombre = nombre;
            ds = cb.CargarAutoCompletarResultadoGeneral("listados");


            if (ds.Tables[0].Rows.Count > 0)
            {


                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {

                    PictureBox pictureBox1 = new PictureBox();
                    panel3.Controls.Add(pictureBox1);
                    if(Int16.Parse(ds.Tables[0].Rows[i]["Tipo"].ToString())==1)
                        pictureBox1.Image = global::MisNotas.Properties.Resources.persona;

                    else if (Int16.Parse(ds.Tables[0].Rows[i]["Tipo"].ToString()) == 2)
                        pictureBox1.Image = global::MisNotas.Properties.Resources.contrato;

                    else if (Int16.Parse(ds.Tables[0].Rows[i]["Tipo"].ToString()) == 3)
                        pictureBox1.Image = global::MisNotas.Properties.Resources.base_de_datos;
                    else 
                        pictureBox1.Image = global::MisNotas.Properties.Resources.archivo;

                    
                    pictureBox1.Location = new System.Drawing.Point(Left, Top);  //14 21
                    pictureBox1.Name = "pictureBox" + ds.Tables[0].Rows[i]["Id"].ToString();
                    pictureBox1.Size = new System.Drawing.Size(89, 73);
                    pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    pictureBox1.TabIndex = 0;
                    pictureBox1.TabStop = false;



                    LinkLabel linkLabel1 = new LinkLabel();
                    panel3.Controls.Add(linkLabel1);
                    linkLabel1.AutoSize = true;
                    linkLabel1.Location = new System.Drawing.Point(114, Top); // 114 23
                    linkLabel1.Name = "linkLabel" + ds.Tables[0].Rows[i]["Id"].ToString();
                    linkLabel1.Size = new System.Drawing.Size(60, 15);
                    linkLabel1.TabIndex = (int)ds.Tables[0].Rows[i]["Id"]; 
                    linkLabel1.TabStop = true;
                    linkLabel1.Text =  ds.Tables[0].Rows[i]["Nombre"].ToString();
                    linkLabel1.LinkColor = Color.Blue;
                    if (Int16.Parse(ds.Tables[0].Rows[i]["Tipo"].ToString()) == 1)
                    {
                        linkLabel1.Click += (sender, EventArgs) => ConsultaPersonas_Click(sender, EventArgs); ;
                    }
                    if (Int16.Parse(ds.Tables[0].Rows[i]["Tipo"].ToString()) == 2)
                    {
                        linkLabel1.Click += (sender, EventArgs) => ConsultaPendientes_Click(sender, EventArgs); ;
                    }
                    if (Int16.Parse(ds.Tables[0].Rows[i]["Tipo"].ToString()) == 3)
                    {
                        linkLabel1.Click += (sender, EventArgs) => ConsultaQuery_Click(sender, EventArgs); ;
                    }
                    if (Int16.Parse(ds.Tables[0].Rows[i]["Tipo"].ToString()) == 4)
                    {
                        linkLabel1.Click += (sender, EventArgs) => ListarResultadoGeneral_Click(sender, EventArgs); ;
                    }



                    Label label2 = new Label();
                    panel3.Controls.Add(label2);
                    label2.AutoSize = true;
                    label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                    label2.Location = new System.Drawing.Point(114, Top2);  //250,Top2
                    label2.Name = "label" + ds.Tables[0].Rows[i]["Id"].ToString();
                    label2.Size = new System.Drawing.Size(233, 15);
                    label2.TabIndex = (int)ds.Tables[0].Rows[i]["Id"];
                    label2.Text = ds.Tables[0].Rows[i]["Observaciones"].ToString();

                   

                    Top2 += 100;
                    Top += 100;

                }

            }


        }


        public void autoCompletar()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            ComboBox cb = new ComboBox();
            DataTable ds = new DataTable();
            cb.Tipo = 8;
            ds = cb.CargarAutoCompletar("listados");

            for (int i = 0; i < ds.Rows.Count; i++)
            {
                lista.Add(ds.Rows[i]["Nombre"].ToString());
            }

            txtBusqueda.AutoCompleteCustomSource = lista;

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

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            listarResultadoGeneral(txtBusqueda.Text);
        }
    }
}
