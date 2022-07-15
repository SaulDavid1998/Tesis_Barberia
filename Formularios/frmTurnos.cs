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
    public partial class frmTurnos : Form
    {
        public frmTurnos()
        {
            InitializeComponent();
        }
        private void PrenderApagarBtnBuscar()
        {
            if (txtNombre.Text.Length > 0 || txtTelefono.Text.Length > 0 || ChkFecha.Checked)
                
            {
                btnBuscar.Enabled = true;
            }
                else
                {
                    btnBuscar.Enabled = false;
                    dgvTurnos.Visible = false;
                   
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvTurnos.Visible = true;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;

            using (TesisEntities db = new TesisEntities())
            {
                var consulta = from t in db.Turno
                               join c in db.Clientes on t.Cliente_Id equals c.Cliente_id
                               select new
                               {
                                   t.Turno_Id,
                                   c.Cliente_id,
                                   t.Hora,
                                   t.FechaDeReserva,
                                   cliente = c.Nombre_Clientes + " " + c.Apellido_Clientes,
                                    c.Telefono,
                                 };
                               


                if (txtTelefono.Text.Trim().Length > 0)
                {
                    consulta = from t in consulta
                               where t.Telefono.StartsWith(txtTelefono.Text)
                               select t;
                }

                if(ChkFecha.Checked)
                {

                    consulta = from t in consulta
                               where t.FechaDeReserva == dtmFecha.Value.Date
                               select t;
                }

                dgvTurnos.AutoGenerateColumns = false;
                dgvTurnos.DataSource = consulta.ToList();
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            PrenderApagarBtnBuscar();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            PrenderApagarBtnBuscar();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            PrenderApagarBtnBuscar();
        }

        private void txtHora_TextChanged(object sender, EventArgs e)
        {
            PrenderApagarBtnBuscar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {  
            frmTurnosAgregar T = new frmTurnosAgregar();
            T.AgregarTurno();
            T.ShowDialog(this);
        }

        private void ChkFecha_CheckedChanged(object sender, EventArgs e)
        {
            PrenderApagarBtnBuscar();
            if (ChkFecha.Checked)
            {
                
                dtmFecha.Enabled = true;
              
            }

            else
            {
                
                dtmFecha.Enabled = false;
              

            }

            
        }

        private void btnTraertodo_Click(object sender, EventArgs e)
        {
            dgvTurnos.Visible = true;
            
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;



            using (TesisEntities db = new TesisEntities())
            {
                var consulta = from t in db.Turno
                               join c in db.Clientes on t.Cliente_Id equals c.Cliente_id
                               select new
                               {
                                   t.Turno_Id,
                                   c.Cliente_id,
                                   t.Hora,
                                   t.FechaDeReserva,
                                   cliente = c.Nombre_Clientes + " " + c.Apellido_Clientes,
                                   c.Telefono,
                               }; 


                dgvTurnos.AutoGenerateColumns = false;

                
                dgvTurnos.DataSource = consulta.ToList();

            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var turnoid = (int)dgvTurnos.SelectedRows[0].Cells[0].Value;
            frmTurnosAgregar T = new frmTurnosAgregar();
            T.ModificarTurno(turnoid);
            T.ShowDialog(this);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmTurnosAgregar T = new frmTurnosAgregar();
            T.EliminarTurno();
            T.ShowDialog(this);
        }
    }
}