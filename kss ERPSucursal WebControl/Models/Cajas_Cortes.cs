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
    
    public partial class Cajas_Cortes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cajas_Cortes()
        {
            this.Cajas_Cortes_IF = new HashSet<Cajas_Cortes_IF>();
        }
    
        public long id_Cajas_Cortes { get; set; }
        public long id_Estaciones_Sesiones { get; set; }
        public long id_FacturaFinal { get; set; }
        public long id_FacturaInicial { get; set; }
        public System.DateTime FechaActual { get; set; }
        public System.DateTime FechaApertura { get; set; }
        public System.DateTime FechaCierre { get; set; }
        public byte nroCorte { get; set; }
        public decimal MontoApetura { get; set; }
        public decimal MontoCuadreCaja { get; set; }
    
        public virtual Estaciones_Sesiones Estaciones_Sesiones { get; set; }
        public virtual Facturas Facturas { get; set; }
        public virtual Facturas Facturas1 { get; set; }
        public virtual Facturas Facturas2 { get; set; }
        public virtual Facturas Facturas3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cajas_Cortes_IF> Cajas_Cortes_IF { get; set; }
    }
}
