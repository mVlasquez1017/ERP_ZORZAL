//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_Vent_FacturaPago
    {
        public long fact_Id { get; set; }
        public string fact_Codigo { get; set; }
        public Nullable<decimal> MontoFactura { get; set; }
        public Nullable<decimal> TotalPago { get; set; }
        public Nullable<decimal> SaldoFactura { get; set; }
    }
}
