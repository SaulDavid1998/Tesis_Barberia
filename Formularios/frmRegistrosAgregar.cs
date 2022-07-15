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
    public partial class frmRegistrosAgregar : Form
    {
        public frmRegistrosAgregar()
        {
            InitializeComponent();
        }

        public void CrearRegistro()
        {
            Text = "Crear Registro";
            EstoyModificandoClienteExistente = false;
            cargarcombos();
            btneliminar.Visible = false;
        }

        public void EliminarRegistro(int registroid)
        {
            Text = "Eliminar Registro";
            btnAceptar.Visible = false;
            cargarregistrodesdedb(registroid);
        }

        public void ModificarRegistro(int registroid)
        {
            Text = "Modificar Registro";
            btnAceptar.Text = "Modificar";
            btneliminar.Visible = false;
            EstoyModificandoClienteExistente = true;
            
            cargarregistrodesdedb(registroid);


        }

        private bool EstoyModificandoClienteExistente;


        private void cargarcombos()
        {
            Helper.LoadBarberos(cmbbarbero);
            Helper.LoadClientes(cmbcliente);
            Helper.LoadMetodoPago(cmbmetodopago);
            Helper.LoadServicios(cmbservicio);
        }

        private void cargarregistrodesdedb(int registroid)
        {
            cargarcombos();

            using(TesisEntities db = new TesisEntities())
            {
                var dbfila = (from sp in db.Servicios_Prestados
                              where sp.ServicioPrestado_Id == registroid
                              select sp).FirstOrDefault();

                if(dbfila !=null)
                {
                    txtid.Text = dbfila.ServicioPrestado_Id.ToString();
                    cmbbarbero.SelectedValue = dbfila.Barbero_Id;
                    cmbcliente.SelectedValue = dbfila.Cliente_Id;
                    cmbmetodopago.SelectedValue = dbfila.TipoDePago_Id;
                    cmbservicio.SelectedValue = dbfila.TipoDeServicio_Id;
                    dtpfecha.Value = dbfila.FechaRealizacion;
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            using (TesisEntities db = new TesisEntities())
            {
                Servicios_Prestados row;

               if(EstoyModificandoClienteExistente)
                {
                    int registroid = int.Parse(txtid.Text);

                    row = (from sp in db.Servicios_Prestados
                           where sp.ServicioPrestado_Id == registroid
                           select sp).FirstOrDefault();
                }
               else
                {
                    row = new Servicios_Prestados();
                    db.Servicios_Prestados.Add(row);
                }


                row.TipoDePago_Id = (int)cmbmetodopago.SelectedValue;
                row.TipoDeServicio_Id = (int)cmbservicio.SelectedValue;
                row.Barbero_Id = (int)cmbbarbero.SelectedValue;
                row.Cliente_Id = (int)cmbcliente.SelectedValue;
                row.FechaRealizacion = dtpfecha.Value;

                if (EstoyModificandoClienteExistente)
                {
                    MessageBox.Show("Se guardaron correctamente los cambios");
                }
                else
                {
                    MessageBox.Show("Se creo el Registro " );
                }
                db.SaveChanges();
            }
            this.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int registroid = int.Parse(txtid.Text);

            using (TesisEntities db = new TesisEntities())
            {

                var consulta = (from sp in db.Servicios_Prestados
                                where sp.ServicioPrestado_Id == registroid
                                select sp).FirstOrDefault();

                db.Servicios_Prestados.Remove(consulta);

                db.SaveChanges();


                MessageBox.Show("Se elimino  el registro");

            }
            this.Close();
        }
    }
}
