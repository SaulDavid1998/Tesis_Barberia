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
    public partial class frmClientes : Form
    {
        public frmClientes()
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
                dgvClientes.Visible = false;
                
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvClientes.Visible = true;

            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;



            TesisEntities db = new TesisEntities();

            var consulta = from c in db.Clientes
                           select c;


            if (txtNombre.Text.Trim().Length > 0)
            {
                consulta = from c in consulta
                           where c.Nombre_Clientes.StartsWith(txtNombre.Text)
                           select c;
            }
            if (txtApellido.Text.Trim().Length > 0)
            {
                consulta = from c in consulta
                           where c.Apellido_Clientes.StartsWith(txtApellido.Text)
                           select c;
            }

            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.DataSource = consulta.ToList();

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            
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
            frmClientesAgregar C = new frmClientesAgregar();
            C.CrearCliente();
            C.ShowDialog();
        }

        private void btnregistros_Click(object sender, EventArgs e)
        {
            dgvClientes.Visible = true;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;



            using (TesisEntities db = new TesisEntities())
            {
                var consulta = from c in db.Clientes
                               select c;
                
                dgvClientes.AutoGenerateColumns = false;
                dgvClientes.DataSource = consulta.ToList();

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            var clienteid = (int)dgvClientes.SelectedRows[0].Cells[0].Value;
            frmClientesAgregar c = new frmClientesAgregar();
            c.ModificarCliente(clienteid);
            c.ShowDialog();
          


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var clienteid = (int)dgvClientes.SelectedRows[0].Cells[0].Value;
            frmClientesAgregar c = new frmClientesAgregar();
            c.BorrarCliente(clienteid);
            c.ShowDialog();
        }
    }
}




