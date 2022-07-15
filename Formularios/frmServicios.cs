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
    public partial class frmServicios : Form
    {
        public frmServicios()
        {
            InitializeComponent();
        }
        private void PrenderApagarBtnBuscar()
        {
            if (chkServicios.Checked)
            {
                btnBuscar.Enabled = true;

            }
            else
            {

                btnBuscar.Enabled = false;
                dgvServicios.Visible = false;

            }
        }
        /*private void CargarcmbServicios( )
        {
           
                using (TesisEntities db = new TesisEntities())
                {

                    var consulta = (from ts in db.TipoDeServicio
                                    orderby ts.Nombre_Servicio
                                    select ts);


                    cmbServicios.ValueMember = "TipoDeServicio_Id";
                    cmbServicios.DisplayMember = "Nombre_Servicio";
                    cmbServicios.DataSource = consulta.ToList();

                }

        }*/

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PrenderApagarBtnBuscar();
            dgvServicios.Visible = true;

            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;

            using (TesisEntities db = new TesisEntities())
            {


                var consulta = from ts in db.TipoDeServicio
                               select ts;


                {
                    consulta = from ts in consulta
                               where ts.TipoDeServicio_Id == (int)cmbServicios.SelectedValue
                               select ts;

                }




                dgvServicios.AutoGenerateColumns = false;
                dgvServicios.DataSource = consulta.ToList();
            }
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmServiciosAgregar S = new frmServiciosAgregar();
            S.ShowDialog(this);
        }

        private void frmServicios_Load(object sender, EventArgs e)
        {

        }

        private void btnTraerTodo_Click(object sender, EventArgs e)
        {
            dgvServicios.Visible = true;

            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;



            using (TesisEntities db = new TesisEntities())
            {
                var consulta = from s in db.TipoDeServicio
                               select s;

                dgvServicios.AutoGenerateColumns = false;
                dgvServicios.DataSource = consulta.ToList();

            }
        }

        private void chkServicios_CheckedChanged(object sender, EventArgs e)
        {

            PrenderApagarBtnBuscar();

            if (chkServicios.Checked)
            {
                Helper.LoadServicios(cmbServicios);
                cmbServicios.Enabled = true;
            }
            else
            {
                cmbServicios.Enabled = false;

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var servicioid = (int)dgvServicios.SelectedRows[0].Cells[0].Value;
            frmServiciosAgregar S = new frmServiciosAgregar();
            S.ModificarServicio(servicioid);
            S.ShowDialog(this);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var servicioid = (int)dgvServicios.SelectedRows[0].Cells[0].Value;
            frmServiciosAgregar S = new frmServiciosAgregar();
            S.EliminarServicio(servicioid);
            S.ShowDialog(this);

        }

       

    }    
}
