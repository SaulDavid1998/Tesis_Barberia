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
    public partial class frmRegistros : Form
    {
        public frmRegistros()
        {
            InitializeComponent();
        }

        private void Prenderapagarbtnbuscar()
        {
            if (chkBarbero.Checked || chkFecha.Checked || chkMetodoPago.Checked || chkServicio.Checked || txtCliente.Text.Trim().Length>0)
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled= false;
                btnModificar.Enabled = false;
                dgvregistros.Visible = false;
                
            }
        }
        /*private void CargarcmbTipoServicio()
        {
            using (TesisEntities db= new TesisEntities())
            {
                var consulta = from ts in db.TipoDeServicio
                               orderby ts.Nombre_Servicio
                               select new
                               {
                                   ts.TipoDeServicio_Id,
                                   ts.Nombre_Servicio,
                               };

                cmbServicio.ValueMember = "TipoDeServicio_Id";
                cmbServicio.DisplayMember = "Nombre_Servicio";
                cmbServicio.DataSource = consulta.ToList();

            }
        }*/

        /*private void CargarcmbBarberos()
        {
            using (TesisEntities db = new TesisEntities())
            {
                var consulta = from b in db.Barberos
                               orderby b.Nombre_Barberos
                               select new
                               {
                                   b.Barbero_Id,
                                   Barbero=b.Nombre_Barberos +" "+ b.Apellido_Barberos
                               };
                cmbBarberos.ValueMember = "Barbero_Id";
                cmbBarberos.DisplayMember = "Barbero";
                cmbBarberos.DataSource = consulta.ToList();
            }
        }*/

        private void frmRegistros_Load(object sender, EventArgs e)
        {
           
           


        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            Prenderapagarbtnbuscar();
        }

        private void chkBarbero_CheckedChanged(object sender, EventArgs e)
        {
            
            if(chkBarbero.Checked)
            {
                cmbBarberos.Enabled = true;
                
                Helper.LoadBarberos(cmbBarberos);
            }
            else
            {
                cmbBarberos.Enabled = false;
               
            }
            Prenderapagarbtnbuscar();
        }

        private void chkMetodoPago_CheckedChanged(object sender, EventArgs e)
        {
            

            if (chkMetodoPago.Checked)
            {
                cmbFormadePago.Enabled = true;
               
                Helper.LoadMetodoPago(cmbFormadePago);
            }
            else
            {
                cmbFormadePago.Enabled = false;
                
            }
            Prenderapagarbtnbuscar();
        }

        private void chkServicio_CheckedChanged(object sender, EventArgs e)
        {
            
            if(chkServicio.Checked)
            {
                Helper.LoadServicios(cmbServicio);
                cmbServicio.Enabled = true;
                
            }
            else
            {
                cmbServicio.Enabled = false;
                
            }
            Prenderapagarbtnbuscar();
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
           

            if(chkFecha.Checked)
            {
                dtpFecha.Enabled = true;
                
            }
            else
            {
                dtpFecha.Enabled = false;
               
            }
            Prenderapagarbtnbuscar();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvregistros.Visible = true;

            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            using (TesisEntities db = new TesisEntities())
            {
                var consulta = from sp in db.Servicios_Prestados
                            join c in db.Clientes on sp.Cliente_Id equals c.Cliente_id
                            join b in db.Barberos on sp.Barbero_Id equals b.Barbero_Id
                            join mp in db.TipoDePago on sp.TipoDePago_Id equals mp.TipoDePago_Id
                            join s in db.TipoDeServicio on sp.TipoDeServicio_Id equals s.TipoDeServicio_Id                            
                            
                            select new
                            {
                                registroid= sp.ServicioPrestado_Id,

                                clienteid=c.Cliente_id,
                                barberoid=b.Barbero_Id,
                                metodopagoid = mp.TipoDePago_Id,
                                servicioid=s.TipoDeServicio_Id,
                                Cliente=c.Nombre_Clientes+ " "+ c.Apellido_Clientes,
                                Barbero =b.Nombre_Barberos+" "+b.Apellido_Barberos,
                                FormadePago=mp.Detalle,
                                Servicio =s.Nombre_Servicio,
                                Fecha=sp.FechaRealizacion,
                            };
             

                
                    consulta = from a in consulta
                               where a.Cliente.StartsWith(txtCliente.Text)
                               select a;
                
                if(chkBarbero.Checked)
                {
                    consulta = from a in consulta
                               where a.barberoid == (int)cmbBarberos.SelectedValue
                               select a;

                }

                if(chkFecha.Checked)
                {
                    consulta = from a in consulta
                               where a.Fecha == dtpFecha.Value.Date
                               select a;
                                
                }
                if (chkServicio.Checked)
                {
                    consulta = from a in consulta
                               where a.servicioid == (int)cmbServicio.SelectedValue
                               select a;
                }

                if (chkMetodoPago.Checked)
                {
                    consulta = from a in consulta
                               where a.metodopagoid == (int)cmbFormadePago.SelectedValue
                               select a;
                }


                dgvregistros.Visible = true;
                dgvregistros.AutoGenerateColumns = false;
                dgvregistros.DataSource = consulta.ToList();
            }
        }
        private void btnCrearRegistro_Click(object sender, EventArgs e)
        {
            frmRegistrosAgregar ra = new frmRegistrosAgregar();
            ra.CrearRegistro();
            ra.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int registroid = (int)dgvregistros.SelectedRows[0].Cells[0].Value;
            frmRegistrosAgregar ra = new frmRegistrosAgregar();
            ra.ModificarRegistro(registroid);
            ra.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int registroid = (int)dgvregistros.SelectedRows[0].Cells[0].Value;

            frmRegistrosAgregar ra = new frmRegistrosAgregar();
            ra.EliminarRegistro(registroid);
            ra.ShowDialog();
        }

        private void btntraertodo_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            using (TesisEntities db = new TesisEntities())
            {
                var consulta = from sp in db.Servicios_Prestados
                               join c in db.Clientes on sp.Cliente_Id equals c.Cliente_id
                               join b in db.Barberos on sp.Barbero_Id equals b.Barbero_Id
                               join mp in db.TipoDePago on sp.TipoDePago_Id equals mp.TipoDePago_Id
                               join s in db.TipoDeServicio on sp.TipoDeServicio_Id equals s.TipoDeServicio_Id

                               select new
                               {
                                   registroid = sp.ServicioPrestado_Id,

                                   clienteid = c.Cliente_id,
                                   barberoid = b.Barbero_Id,
                                   metodopagoid = mp.TipoDePago_Id,
                                   servicioid = s.TipoDeServicio_Id,
                                   Cliente = c.Nombre_Clientes + " " + c.Apellido_Clientes,
                                   Barbero = b.Nombre_Barberos + " " + b.Apellido_Barberos,
                                   FormadePago = mp.Detalle,
                                   Servicio = s.Nombre_Servicio,
                                   Fecha = sp.FechaRealizacion,
                               };

                dgvregistros.Visible = true;
                dgvregistros.AutoGenerateColumns = false;
                dgvregistros.DataSource = consulta.ToList();

            }
        }
    }
}
