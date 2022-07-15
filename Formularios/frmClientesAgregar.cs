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
    public partial class frmClientesAgregar : Form
    {
        public frmClientesAgregar()
        {
            InitializeComponent();
        }

        private bool EstoyModificandoClienteExistente;
        public void CrearCliente()
        {
            
            Text = "Agregar Cliente";
            btnAgregar.Text = "Crear";
            btneliminar.Visible = false;
            
        }

        public void BorrarCliente(int clienteid)
        {
            Text = "Borrar Cliente";
            btnAgregar.Text = "Modificar";
            btnAgregar.Visible = false;
            btnLimpiar.Visible = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false; ;
            txtDomicilio.Enabled = false;
            txtCelular.Enabled = false;
            txtInstagram.Enabled = false;
            txtFacebook.Enabled = false;
            txtEdad.Enabled = false;
            CargarDesdeDb(clienteid);
        }


        public void ModificarCliente(int clienteid)
        {
            Text = "Modificar Cliente";
            btnAgregar.Text = "Modificar";
            btneliminar.Visible = false;
            btnLimpiar.Visible = false;
            EstoyModificandoClienteExistente = true;
            CargarDesdeDb(clienteid);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDomicilio.Clear();
            txtCelular.Clear();
            txtInstagram.Clear();
            txtFacebook.Clear();
            txtEdad.Clear();
            
        }

        private void CargarDesdeDb(int clienteid)
        {
            using (TesisEntities db = new TesisEntities())
            {
                var row = (from c in db.Clientes
                           where c.Cliente_id == clienteid
                           select c).FirstOrDefault();
                if (row != null)
                {
                    /// Transfiero los valores. 
                    /// Los datos van desde la fila de la BD hacia los controles correspondientes
                    /// 
                    txtid.Text = row.Cliente_id.ToString();
                    txtNombre.Text = row.Nombre_Clientes;
                    txtApellido.Text = row.Apellido_Clientes;
                    txtDomicilio.Text = row.Domicilio_Clientes;
                    txtCelular.Text = row.Telefono;
                    txtInstagram.Text = row.Instagram;
                    txtFacebook.Text = row.Facebook;
                    txtEdad.Text = row.Edad_Clientes.ToString();
                    
                }

                else
                {

                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (TesisEntities db = new TesisEntities())
            {
                Clientes row;

                if(EstoyModificandoClienteExistente)
                {
                    int clienteid = int.Parse(txtid.Text);
                    row = (from c in db.Clientes
                           where c.Cliente_id == clienteid
                           select c).FirstOrDefault();

                    
                }
                else
                {
                    row = new Clientes();
                    db.Clientes.Add(row);
                    
                }

                row.Nombre_Clientes = txtNombre.Text;
                row.Apellido_Clientes=txtApellido.Text ;
                row.Telefono=txtCelular.Text ;
                row.Domicilio_Clientes=txtDomicilio.Text ;
                row.Instagram= txtInstagram.Text ;
                row.Edad_Clientes=short.Parse(txtEdad.Text);
                row.Facebook = txtFacebook.Text;

                if (EstoyModificandoClienteExistente)
                {
                    MessageBox.Show("Se guardaron correctamente los cambios");
                }
                else
                {
                    MessageBox.Show("Se creo el cliente " + row.Nombre_Clientes + " " + row.Apellido_Clientes);
                }
                db.SaveChanges();
                
            }

            this.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int clienteid = (int.Parse(txtid.Text));
            using (TesisEntities db = new TesisEntities())
            {

                var consulta = (from c in db.Clientes
                                where c.Cliente_id == clienteid
                                select c).FirstOrDefault();

                db.Clientes.Remove(consulta);

                db.SaveChanges();


                MessageBox.Show("Se elimino  el cliente " + consulta.Nombre_Clientes + " " +consulta.Apellido_Clientes );

            }
            this.Close();
        }
    }
}
