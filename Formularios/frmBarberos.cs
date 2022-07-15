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
    public partial class frmBarberos : Form
    {
        public frmBarberos()
        {
            InitializeComponent();
        }

        private void PrenderApagarBtnBuscar()
        {
            if (txtNombre.Text.Length > 0 || txtApellido.Text.Length > 0)
            {
                btnBuscar.Enabled = true;
            }

            else
            {
                btnBuscar.Enabled = false;
                dgvBarberos.Visible = false;
               
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvBarberos.Visible = true;
           
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;


            using (TesisEntities db = new TesisEntities())
            {
                var consulta = from b in db.Barberos
                               select b;

                if (txtNombre.Text.Trim().Length > 0)
                {
                    consulta = from b in consulta
                               where b.Nombre_Barberos.StartsWith(txtNombre.Text)
                               select b;
                }
                if (txtApellido.Text.Trim().Length > 0)
                {
                    consulta = from b in consulta
                               where b.Apellido_Barberos.StartsWith(txtApellido.Text)
                               select b;
                }

                dgvBarberos.AutoGenerateColumns = false;
                dgvBarberos.DataSource = consulta.ToList();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmBarberosAgregar A = new frmBarberosAgregar();
            A.CrearBarbero();
            A.ShowDialog(this);

        }

        private void btntraertodo_Click(object sender, EventArgs e)
        {
            dgvBarberos.Visible = true;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;



            using (TesisEntities db = new TesisEntities())
            {
                var consulta = from b in db.Barberos
                               select b;

                dgvBarberos.AutoGenerateColumns = false;
                dgvBarberos.DataSource = consulta.ToList();

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var barberoid = (int)dgvBarberos.SelectedRows[0].Cells[0].Value;
            frmBarberosAgregar A = new frmBarberosAgregar();
            A.ModificarBarbero(barberoid);
            A.ShowDialog(this);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var barberoid = (int)dgvBarberos.SelectedRows[0].Cells[0].Value;
            frmBarberosAgregar b = new frmBarberosAgregar();
            b.BorrarBarbero(barberoid);
            b.ShowDialog();
        }
    }
    
}
