//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tesis_Barberia.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoDePago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoDePago()
        {
            this.Servicios_Prestados = new HashSet<Servicios_Prestados>();
        }
    
        public int TipoDePago_Id { get; set; }
        public string Detalle { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servicios_Prestados> Servicios_Prestados { get; set; }
    }
}