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
    
    public partial class Estaciones_Sesiones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estaciones_Sesiones()
        {
            this.Cajas_Cortes = new HashSet<Cajas_Cortes>();
            this.Cajas_Egresos = new HashSet<Cajas_Egresos>();
            this.Estaciones_Sesiones_Detalle = new HashSet<Estaciones_Sesiones_Detalle>();
            this.Facturas_Modificadas = new HashSet<Facturas_Modificadas>();
        }
    
        public long id_Estaciones_Sesiones { get; set; }
        public Nullable<short> id_Empleados { get; set; }
        public short id_estaciones { get; set; }
        public Nullable<short> id_Cajas { get; set; }
        public Nullable<short> id_Usuarios { get; set; }
        public Nullable<bool> esEstacionActiva { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaFin { get; set; }
        public string IPEstacion { get; set; }
        public string ModuloActual { get; set; }
        public string NombreEquipo { get; set; }
    
        public virtual Cajas Cajas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cajas_Cortes> Cajas_Cortes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cajas_Egresos> Cajas_Egresos { get; set; }
        public virtual Empleados Empleados { get; set; }
        public virtual Estaciones Estaciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estaciones_Sesiones_Detalle> Estaciones_Sesiones_Detalle { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facturas_Modificadas> Facturas_Modificadas { get; set; }
    }
}