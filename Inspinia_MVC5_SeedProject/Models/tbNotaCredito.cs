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
    
    public partial class tbNotaCredito
    {
        public short nocre_Id { get; set; }
        public string nocre_Codigo { get; set; }
        public Nullable<int> dev_Id { get; set; }
        public int clte_Id { get; set; }
        public short suc_Id { get; set; }
        public Nullable<bool> nocre_Anulado { get; set; }
        public System.DateTime nocre_FechaEmision { get; set; }
        public string nocre_MotivoEmision { get; set; }
        public Nullable<decimal> nocre_Monto { get; set; }
        public int nocre_UsuarioCrea { get; set; }
        public System.DateTime nocre_FechaCrea { get; set; }
        public Nullable<int> nocre_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> nocre_FechaModifica { get; set; }
        public bool nocre_Estado { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbCliente tbCliente { get; set; }
        public virtual tbDevolucion tbDevolucion { get; set; }
        public virtual tbSucursal tbSucursal { get; set; }
    }
}
