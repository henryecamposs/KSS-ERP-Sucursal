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
    
    public partial class TiposEgreso_Caja
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TiposEgreso_Caja()
        {
            this.Cajas_Egresos = new HashSet<Cajas_Egresos>();
        }
    
        public short id_TiposEgreso_Caja { get; set; }
        public string TipoEgreso { get; set; }
        public bool esPideComentario { get; set; }
        public bool esPideAutorizacion { get; set; }
        public decimal MontoMaximo { get; set; }
        public decimal MontoMinimo { get; set; }
        public bool esImprimeRecibo { get; set; }
        public bool esFiscal { get; set; }
        public bool esPideID_asociado { get; set; }
        public bool esPideNroDoc_Asociado { get; set; }
        public bool esPideNombreRecibe { get; set; }
        public bool esPideNombreEntrega { get; set; }
        public string TablaAsociada { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cajas_Egresos> Cajas_Egresos { get; set; }
    }
}