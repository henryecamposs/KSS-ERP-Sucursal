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
    
    public partial class TiposImpuestos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TiposImpuestos()
        {
            this.Facturas_Detalle_Impuestos = new HashSet<Facturas_Detalle_Impuestos>();
            this.Facturas_Impuestos = new HashSet<Facturas_Impuestos>();
            this.Productos_Impuestos = new HashSet<Productos_Impuestos>();
        }
    
        public short Id_TiposImpuestos { get; set; }
        public bool esIncluido { get; set; }
        public System.DateTime FachaModificado { get; set; }
        public string Impuesto { get; set; }
        public double Tasa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facturas_Detalle_Impuestos> Facturas_Detalle_Impuestos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facturas_Impuestos> Facturas_Impuestos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos_Impuestos> Productos_Impuestos { get; set; }
    }
}
