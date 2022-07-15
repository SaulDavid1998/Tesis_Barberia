using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesis_Barberia.Data;

namespace Tesis_Barberia.Formularios
{
    public partial class frmBarberosAgregar : Form
    {
        public frmBarberosAgregar()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDomicilio.Clear();
            txtCelular.Clear();
            txtInstagram.Clear();
            txtEdad.Clear();
            dtpFechaContratacion.Value = DateTime.Now;

        }



        public void CrearBarbero()
        {

            Text = "Agregar Barbero";
            btneliminar.Visible = false;
            btnAgregar.Text = "Crear";

        }

        public void BorrarBarbero(int barberoid)
        {
            Text = "Borrar Barbero";
            btnAgregar.Visible = false;
            btnLimpiar.Visible = false;
            txtid.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDomicilio.Enabled = false;
            txtCelular.Enabled = false;
            txtInstagram.Enabled = false;
            txtfacebook.Enabled = false;
            dtpFechaContratacion.Enabled = false;
            txtEdad.Enabled = false;
            CargarDesdeDb(barberoid);
        }


        public void ModificarBarbero(int clienteid)
        {
            Text = "Modificar Barbero";
            btnAgregar.Text = "Modificar";
            btneliminar.Visible = false;
            EstoyModificandoBarberoExistente = true;
            CargarDesdeDb(clienteid);
        }


        private bool EstoyModificandoBarberoExistente;


        private void CargarDesdeDb(int barberoid)
        {
            using (TesisEntities db = new TesisEntities())
            {
                var row = (from b in db.Barberos
                           where b.Barbero_Id == barberoid
                           select b).FirstOrDefault();
                if (row != null)
                {
                    /// Transfiero los valores. 
                    /// Los datos van desde la fila de la BD hacia los controles correspondientes
                    /// 
                    txtid.Text = row.Barbero_Id.ToString();
                    txtNombre.Text = row.Nombre_Barberos;
                    txtApellido.Text = row.Apellido_Barberos;
                    txtDomicilio.Text = row.Domicilio_Barberos;
                    txtCelular.Text = row.Telefono_Barberos;
                    txtInstagram.Text = row.Instagram_Barberos;
                    txtfacebook.Text = row.Facebook_Barberos;
                    dtpFechaContratacion.Value = row.Fecha_Contrato;
                    txtEdad.Text = row.Edad_Barberos.ToString();

                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (TesisEntities db = new TesisEntities())
            {
                Barberos row;
                if(EstoyModificandoBarberoExistente)
                {
                    int clienteid = int.Parse(txtid.Text);
                    row = (from b in db.Barberos
                           where b.Barbero_Id == clienteid
                           select b).FirstOrDefault();
                }
                else
                {
                    row = new Barberos();
                    db.Barberos.Add(row);
                }

                row.Nombre_Barberos = txtNombre.Text;
                row.Apellido_Barberos = txtApellido.Text;
                row.Telefono_Barberos = txtCelular.Text;
                row.Domicilio_Barberos = txtDomicilio.Text;
                row.Instagram_Barberos = txtInstagram.Text;
                row.Edad_Barberos = short.Parse(txtEdad.Text);
                row.Facebook_Barberos = txtfacebook.Text;
                row.Fecha_Contrato = dtpFechaContratacion.Value;

                if (EstoyModificandoBarberoExistente)
                {
                    MessageBox.Show("Se guardaron correctamente los cambios");
                }
                else
                {
                    MessageBox.Show("Se creo el servicio " + row.Nombre_Barberos+" "+row.Apellido_Barberos );
                }
                db.SaveChanges();

                
            }

            this.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int barberoid = int.Parse(txtid.Text);
            using(TesisEntities db = new TesisEntities())
            {
                var consulta = (from b in db.Barberos
                                where b.Barbero_Id == barberoid
                                select b).FirstOrDefault();

                db.Barberos.Remove(consulta);
                db.SaveChanges();
                MessageBox.Show("Se elimino correctamente el cliente " + consulta.Nombre_Barberos+" "+consulta.Apellido_Barberos);

            }
            this.Close();
        }
    }
}
