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
    
    public partial class world_Regiones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public world_Regiones()
        {
            this.Clientes = new HashSet<Clientes>();
            this.Empleados = new HashSet<Empleados>();
            this.Empresas_Sucursales = new HashSet<Empresas_Sucursales>();
            this.ven_Municipios = new HashSet<ven_Municipios>();
            this.world_Localidades = new HashSet<world_Localidades>();
        }
    
        public short id_Regiones { get; set; }
        public short id_World_Paises { get; set; }
        public short id_World_Idiomas { get; set; }
        public string Region { get; set; }
        public float x { get; set; }
        public float y { get; set; }
        public int exacto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clientes> Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleados> Empleados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empresas_Sucursales> Empresas_Sucursales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ven_Municipios> ven_Municipios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<world_Localidades> world_Localidades { get; set; }
        public virtual world_Paises world_Paises { get; set; }
    }
}
