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
    
    public partial class Licencias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Licencias()
        {
            this.Estaciones = new HashSet<Estaciones>();
        }
    
        public short id_Licencias { get; set; }
        public string CodigoActivacion { get; set; }
        public string CodigoRequerido { get; set; }
        public string CodigoSerial { get; set; }
        public string hdd_Serial { get; set; }
        public string MotherBoard_Serial { get; set; }
        public string NombreEquipo { get; set; }
        public string SistemaOperativo { get; set; }
        public string SO_Version { get; set; }
        public System.DateTime FechaActual { get; set; }
        public Nullable<bool> esOnline { get; set; }
        public bool esActivo { get; set; }
        public short id_Empresas_Sucursales { get; set; }
        public System.DateTime FechaInstalacion { get; set; }
    
        public virtual Empresas_Sucursales Empresas_Sucursales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estaciones> Estaciones { get; set; }
    }
}