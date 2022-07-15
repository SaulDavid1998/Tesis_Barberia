using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesis_Barberia.Data;

namespace Tesis_Barberia.Codigo
{
     class Helper
    {

        public static void  LoadClientes (ComboBox cmbcliente)
        {
            using (TesisEntities db = new TesisEntities())
            {
                var consulta = from c in db.Clientes
                               orderby c.Nombre_Clientes
                               select new
                {
                                   c.Cliente_id,
                                   nombre= c.Nombre_Clientes + " "+ c.Apellido_Clientes,
                };
                               
                cmbcliente.DisplayMember = "nombre";
                cmbcliente.ValueMember = "Cliente_id"; 
                cmbcliente.DataSource = consulta.ToList();
            }
        }

        public static void LoadBarberos(ComboBox cmbbarberos)
        {
            using (TesisEntities db = new TesisEntities())
            {
                var consulta = from b in db.Barberos
                               orderby b.Nombre_Barberos
                               select new
                               {
                                   b.Barbero_Id,
                                   Barbero = b.Nombre_Barberos + " " + b.Apellido_Barberos
                               };
                cmbbarberos.ValueMember = "Barbero_Id";
                cmbbarberos.DisplayMember = "Barbero";
                cmbbarberos.DataSource = consulta.ToList();
            }
        }

        public static void LoadServicios(ComboBox cmbservicios)
        {
            if(cmbservicios.DataSource==null)
            using (TesisEntities db = new TesisEntities())
            {
                var consulta = from ts in db.TipoDeServicio
                               orderby ts.Nombre_Servicio
                               select ts;
                cmbservicios.DisplayMember = "Nombre_Servicio";
                cmbservicios.ValueMember = "TipoDeServicio_Id"; 
                cmbservicios.DataSource = consulta.ToList();
            }
        }

        public static void LoadMetodoPago (ComboBox cmbmetododepago)
        {
            using (TesisEntities db = new TesisEntities())
            {
                var consulta = from mp in db.TipoDePago
                               orderby mp.Detalle   
                               select mp;
                cmbmetododepago.ValueMember = "TipoDePago_Id";
                cmbmetododepago.DisplayMember = "Detalle";
                cmbmetododepago.DataSource = consulta.ToList();
            }
        }

    }
}
