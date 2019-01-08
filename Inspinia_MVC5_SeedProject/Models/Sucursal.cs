﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ERP_GMEDINA.Models
{
    [MetadataType(typeof(SucursalMetaData))]
    public partial class tbSucursal
    {


    }
    public class SucursalMetaData
    {
        [Display(Name ="Id")]
        public short suc_Id { get; set; }

        [Display(Name ="Municipio")]
        public string mun_Codigo { get; set; }

        [Display(Name = "Bodega")]
        public int bod_Id { get; set; }

        [Display(Name = "Punto Emisión")]
        public int pemi_Id { get; set; }

        [Display(Name = "Sucursal")]
        public string suc_Descripcion { get; set; }

        [Display(Name = "Correo")]
        public string suc_Correo { get; set; }

        [Display(Name = "Dirección")]
        public string suc_Direccion { get; set; }

        [Display(Name = "Teléfono")]
        public string suc_Telefono { get; set; }

        [Display(Name = "Usuario Creación")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public int suc_UsuarioCrea { get; set; }

        [Display(Name = "Fecha Creación")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "El campo {0} es requerido")]
        public System.DateTime suc_FechaCrea { get; set; }

        [Display(Name = "Usuario Modificación")]
        public Nullable<int> suc_UsuarioModifica { get; set; }

        [Display(Name = "Fecha Modificación")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> suc_FechaModifica { get; set; }
    }
}