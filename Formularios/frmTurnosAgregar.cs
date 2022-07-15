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
    public partial class frmTurnosAgregar : Form
    {
        public frmTurnosAgregar()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            
            
            txtTelefono.Clear();
            dtpFecha.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
            
        }


        public void AgregarTurno()
        {
            Text = "Agregar Turno";
            btneliminar.Visible = false;
            cargarcmbclientes();
        }

        public void ModificarTurno(int turnoid)
        {
            EstoyModificandoTurno = true;
            Text = "Modificar Turno";
            btneliminar.Visible = false;
            CargarTurnodesdeDb(turnoid);
            cargarcmbclientes();
        }

        public void EliminarTurno()
        {
            Text = "Eliminar Turno";
            btnAgregar.Visible = false;
            btnLimpiar.Visible = false;
        }

        private bool EstoyModificandoTurno;

        private void cargarcmbclientes()
        {
            Helper.LoadClientes(cmbcliente);
        }

        private void CargarTurnodesdeDb(int turnoid)
        {
            cargarcmbclientes();
            using (TesisEntities db = new TesisEntities())
            {
                var consulta = (from t in db.Turno
                                join c in db.Clientes on t.Cliente_Id equals c.Cliente_id
                                where t.Turno_Id == turnoid
                                select t).FirstOrDefault();
                

                if(consulta !=null)
                {
                    txtid.Text = consulta.Turno_Id.ToString();
                    cmbcliente.SelectedValue = consulta.Cliente_Id;
                    //txtTelefono.Text=//ESTO SE LO PEGUNTAMOS A Lastrico
                    dtpFecha.Value = consulta.FechaDeReserva.Date;
                   
                    
                }
               


               
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            using(TesisEntities db = new TesisEntities())
            {
                Turno fila;
                if (EstoyModificandoTurno)
                {
                    int turnoid = int.Parse(txtid.Text);
                    fila = (from t in db.Turno
                             where t.Turno_Id == turnoid
                             select t).FirstOrDefault();
                }
                else
                {
                    fila = new Turno();
                    db.Turno.Add(fila);
                }

                fila.FechaDeReserva = dtpFecha.Value;
                if (EstoyModificandoTurno)
                {
                    MessageBox.Show("Se guardaron correctamente los cambios");
                }
                else
                {
                    MessageBox.Show("Se creo el Turno");
                }
            }

            this.Close();
        }
    }
}
