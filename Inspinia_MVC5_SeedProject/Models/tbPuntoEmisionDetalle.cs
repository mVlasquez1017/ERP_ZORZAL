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
    
    public partial class tbPuntoEmisionDetalle
    {
        public int pemid_Id { get; set; }
        public int pemi_Id { get; set; }
        public byte dfisc_Id { get; set; }
        public string pemid_RangoInicio { get; set; }
        public string pemid_RangoFinal { get; set; }
        public System.DateTime pemid_FechaLimite { get; set; }
        public int pemid_UsuarioCrea { get; set; }
        public System.DateTime pemid_FechaCrea { get; set; }
        public Nullable<int> pemid_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> pemid_FechaModifica { get; set; }
    
        public virtual tbPuntoEmision tbPuntoEmision { get; set; }
    }
}