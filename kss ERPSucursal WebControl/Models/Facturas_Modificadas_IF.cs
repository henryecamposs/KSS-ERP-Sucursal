//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kss_ERPSucursal_WebControl.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Facturas_Modificadas_IF
    {
        public long id_Facturas_Modificadas_IF { get; set; }
        public long id_Facturas_Modificadas { get; set; }
        public System.DateTime Fecha_IF { get; set; }
        public decimal MontoTotal1 { get; set; }
        public Nullable<decimal> MontoTotal2 { get; set; }
        public Nullable<decimal> MontoTotal3 { get; set; }
        public int NroRef_IF { get; set; }
        public string nroSerial_IF { get; set; }
        public string RIF_IF { get; set; }
        public decimal Tasa1 { get; set; }
        public Nullable<decimal> Tasa2 { get; set; }
        public Nullable<decimal> Tasa3 { get; set; }
    
        public virtual Facturas_Modificadas Facturas_Modificadas { get; set; }
    }
}
