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
    
    public partial class tbEmpleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbEmpleado()
        {
            this.tbBodega = new HashSet<tbBodega>();
            this.tbUsuario2 = new HashSet<tbUsuario>();
        }
    
        public short emp_Id { get; set; }
        public string emp_Nombres { get; set; }
        public string emp_Apellidos { get; set; }
        public string emp_Sexo { get; set; }
        public System.DateTime emp_FechaNacimiento { get; set; }
        public byte tpi_Id { get; set; }
        public string emp_Identificacion { get; set; }
        public string emp_Telefono { get; set; }
        public string emp_Correoelectronico { get; set; }
        public string emp_TipoSangre { get; set; }
        public string emp_Puesto { get; set; }
        public System.DateTime emp_FechaIngreso { get; set; }
        public string emp_Direccion { get; set; }
        public string emp_Observaciones { get; set; }
        public int emp_UsuarioCrea { get; set; }
        public System.DateTime emp_FechaCrea { get; set; }
        public Nullable<int> emp_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> emp_FechaModifica { get; set; }
        public bool emp_Estado { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbTipoIdentificacion tbTipoIdentificacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbBodega> tbBodega { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbUsuario> tbUsuario2 { get; set; }
    }
}
