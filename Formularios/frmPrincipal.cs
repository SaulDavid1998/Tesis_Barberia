using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tesis_Barberia.Formularios
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        } 

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnclientes_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmClientes"] != null)
            {
                Application.OpenForms["frmClientes"].WindowState = FormWindowState.Maximized;
                Application.OpenForms["frmClientes"].Activate();
                
            }

            else
            {
                frmClientes clientes = new frmClientes();
                clientes.MdiParent = this;
                clientes.Show();
                
            }
            
        }

        private void btnBarberos_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmBarberos"] != null)
            {
                Application.OpenForms["frmBarberos"].WindowState = FormWindowState.Maximized;
                Application.OpenForms["frmBarberos"].Activate();
            }

            else
            {
                frmBarberos Barberos = new frmBarberos();
                Barberos.MdiParent = this;
                Barberos.Show();
            }
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmServicios"] != null)
            {
                Application.OpenForms["frmServicios"].WindowState = FormWindowState.Maximized;
                Application.OpenForms["frmServicios"].Activate();              
            }

            else
            {
                frmServicios Servicios = new frmServicios();                            
                Servicios.MdiParent = this;               
                Servicios.Show();
            }
        }

        private void btnTurno_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmTurnos"] != null)
            {
                Application.OpenForms["frmTurnos"].WindowState = FormWindowState.Maximized;
                Application.OpenForms["frmTurnos"].Activate();
            }

            else
            {
                frmTurnos Turnos = new frmTurnos();
                Turnos.MdiParent = this;
                Turnos.Show();
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRegistros"] != null)
            {
                Application.OpenForms["frmRegistros"].WindowState = FormWindowState.Maximized;
                Application.OpenForms["frmRegistros"].Activate();
            }

            else
            {
                frmRegistros Registros = new frmRegistros();
                Registros.MdiParent = this;
                Registros.Show();
            }
        }
    }
}
    
    
    
