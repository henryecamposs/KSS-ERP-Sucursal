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
    
    public partial class Facturas_Servicios
    {
        public long id_Facturas_Servicios { get; set; }
        public long id_Facturas { get; set; }
        public Nullable<short> id_defStatusFactura { get; set; }
        public Nullable<short> id_Empleados { get; set; }
        public string Comentarios { get; set; }
        public Nullable<System.DateTime> FechaEntrega { get; set; }
        public Nullable<System.DateTime> FechaEntrada { get; set; }
        public Nullable<System.DateTime> FechaTentativaEntrega { get; set; }
        public string NombreRecibe { get; set; }
        public Nullable<byte> nroDiasGarantia { get; set; }
        public string nroRecibo { get; set; }
        public Nullable<System.DateTime> FechaAtencionServicio { get; set; }
    
        public virtual Empleados Empleados { get; set; }
        public virtual Facturas Facturas { get; set; }
    }
}
