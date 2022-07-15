using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesis_Barberia.Codigo;
using Tesis_Barberia.Data;

namespace Tesis_Barberia.Formularios
{
    public partial class frmServiciosAgregar : Form
    {
        public frmServiciosAgregar()
        {
            InitializeComponent();
        }

        private bool EstoyModificandoServicioExistente;

       
        private void CargarDesdeDb(int servicioid)
        {
            using (TesisEntities db = new TesisEntities())
            {
                var row = (from ts in db.TipoDeServicio
                           where ts.TipoDeServicio_Id == servicioid
                           select ts).FirstOrDefault();
                if(row !=null)
                {
                    /// Transfiero los valores. 
                    /// Los datos van desde la fila de la BD hacia los controles correspondientes
                    /// 
                    txtid.Text = row.TipoDeServicio_Id.ToString();
                    txtNombre.Text = row.Nombre_Servicio;
                    txtPrecio.Text = row.Precio.ToString();
                }

                else
                {

                }
            }
        }
        private void CargarCombos()
        {
           
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtPrecio.Clear();

        }

        public void AgregarServicio()
        {
            Text = "Agregar Servicio";
            btneliminar.Visible = false;

        }

        public void EliminarServicio(int servicioid)
        {
            Text = "Eliminar Servicio";
            btneliminar.Visible = true;
            btnLimpiar.Visible = false;
            btnAgregar.Visible = false;
           
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            CargarDesdeDb(servicioid);
        }

        public void ModificarServicio(int servicioid)
        {
            Text = "Modificar Servicio";
            btneliminar.Visible = false;
            btnAgregar.Text = "Modificar";
            EstoyModificandoServicioExistente = true;
            CargarDesdeDb(servicioid);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            using (TesisEntities db = new TesisEntities())
            {
                TipoDeServicio Row;


                if (EstoyModificandoServicioExistente)
                {
                    int servicioid = int.Parse(txtid.Text);
                    Row = (from ts in db.TipoDeServicio
                             where ts.TipoDeServicio_Id== servicioid
                           select ts).FirstOrDefault();

                }
                else
                {
                     
                   
                        Row = new TipoDeServicio();
                    db.TipoDeServicio.Add(Row);
 
                }

                
                Row.Nombre_Servicio = txtNombre.Text;
                Row.Precio = int.Parse(txtPrecio.Text);

                if (EstoyModificandoServicioExistente)
                {
                    MessageBox.Show("Se guardaron correctamente los cambios");
                }
                else
                {
                    MessageBox.Show("Se creo el servicio " + Row.Nombre_Servicio);
                }
                    db.SaveChanges();
                
            }
            this.Close();
        }

       

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            int servicioid = (int.Parse(txtid.Text));

            using (TesisEntities db = new TesisEntities())
            {

                var consulta = (from ts in db.TipoDeServicio
                                where ts.TipoDeServicio_Id == servicioid
                                select ts).FirstOrDefault();

                db.TipoDeServicio.Remove(consulta);

                db.SaveChanges();


                MessageBox.Show("Se elimino correctamente el servicio " + consulta.Nombre_Servicio);
               
            }

            

            this.Close();
        }
    }
}
