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
    
    public partial class tbRolesUsuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbRolesUsuario()
        {
            this.tbAccesoRol = new HashSet<tbAccesoRol>();
        }
    
        public int rolu_Id { get; set; }
        public int rol_Id { get; set; }
        public int usu_Id { get; set; }
        public int rolu_UsuarioCrea { get; set; }
        public System.DateTime rolu_FechaCrea { get; set; }
        public Nullable<int> rolu_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> rolu_FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAccesoRol> tbAccesoRol { get; set; }
        public virtual tbRol tbRol { get; set; }
        public virtual tbUsuario tbUsuario { get; set; }
    }
}