//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbEntradaDetalle
    {
        public int entd_Id { get; set; }
        public int ent_Id { get; set; }
        public string prod_Codigo { get; set; }
        public decimal entd_Cantidad { get; set; }
        public int entd_UsuarioCrea { get; set; }
        public System.DateTime entd_FechaCrea { get; set; }
        public Nullable<int> entd_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> entd_FechaModifica { get; set; }
        public Nullable<int> uni_Id { get; set; }
    
        public virtual tbUnidadMedida tbUnidadMedida { get; set; }
        public virtual tbEntrada tbEntrada { get; set; }
        public virtual tbProducto tbProducto { get; set; }
    }
}
