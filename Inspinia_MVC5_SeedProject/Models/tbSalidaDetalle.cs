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
    
    public partial class tbSalidaDetalle
    {
        public int sald_Id { get; set; }
        public int sal_Id { get; set; }
        public string prod_Codigo { get; set; }
        public decimal sal_Cantidad { get; set; }
        public string box_Codigo { get; set; }
        public int sald_UsuarioCrea { get; set; }
        public System.DateTime sald_FechaCrea { get; set; }
        public Nullable<int> sald_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> sald_FechaModifica { get; set; }
        public decimal sald_Cantidad { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbBox tbBox { get; set; }
        public virtual tbProducto tbProducto { get; set; }
        public virtual tbSalida tbSalida { get; set; }
    }
}
