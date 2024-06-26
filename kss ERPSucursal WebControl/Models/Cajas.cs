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
    
    public partial class Cajas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cajas()
        {
            this.Estaciones_Sesiones = new HashSet<Estaciones_Sesiones>();
            this.Facturas = new HashSet<Facturas>();
        }
    
        public short id_Cajas { get; set; }
        public Nullable<short> id_Estaciones { get; set; }
        public long id_Clientes { get; set; }
        public short id_TiposPago { get; set; }
        public short id_DefTiposPrecio { get; set; }
        public decimal CantidadUnidadVentaPred { get; set; }
        public Nullable<bool> esAbierta { get; set; }
        public Nullable<bool> esActivo { get; set; }
        public Nullable<bool> esAgruparItemsIdenticos { get; set; }
        public bool esNroFactura_Person { get; set; }
        public Nullable<bool> esRemoto { get; set; }
        public Nullable<System.DateTime> FechaAnterior { get; set; }
        public Nullable<System.DateTime> FechaApertura { get; set; }
        public decimal MontoApertura { get; set; }
        public string Nombre { get; set; }
        public Nullable<byte> NroFacturaAnteior_IF { get; set; }
        public byte NroFacturaAnterior { get; set; }
        public string Serial_IF { get; set; }
    
        public virtual Estaciones Estaciones { get; set; }
        public virtual TiposPago TiposPago { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estaciones_Sesiones> Estaciones_Sesiones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facturas> Facturas { get; set; }
    }
}
