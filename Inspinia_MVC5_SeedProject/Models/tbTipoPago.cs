//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_ZORZAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbTipoPago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbTipoPago()
        {
            this.tbPago = new HashSet<tbPago>();
        }
    
        public short tpa_Id { get; set; }
        public string tpa_Descripcion { get; set; }
        public string tpa_Emisor { get; set; }
        public string tpa_Cuenta { get; set; }
        public string tpa_FechaVencimiento { get; set; }
        public string tpa_Titular { get; set; }
        public int tpa_UsuarioCrea { get; set; }
        public System.DateTime tpa_FechaCrea { get; set; }
        public Nullable<int> tpa_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> tpa_FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPago> tbPago { get; set; }
    }
}