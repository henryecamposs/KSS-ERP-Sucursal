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
    
    public partial class Empresas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empresas()
        {
            this.Empresas_Sucursales = new HashSet<Empresas_Sucursales>();
        }
    
        public short id_empresas { get; set; }
        public Nullable<long> id_world_localidades { get; set; }
        public short id_world_Regiones { get; set; }
        public Nullable<short> id_World_Idiomas { get; set; }
        public Nullable<short> id_ven_municipios { get; set; }
        public Nullable<short> id_world_paises { get; set; }
        public Nullable<short> id_ven_parroquias { get; set; }
        public short id_tiposComercio { get; set; }
        public string codigoPostal { get; set; }
        public string Contacto { get; set; }
        public string direccion { get; set; }
        public string empresa { get; set; }
        public Nullable<bool> esActivo { get; set; }
        public string ImagenArchivo { get; set; }
        public string nit { get; set; }
        public string rif { get; set; }
        public string telefonos { get; set; }
        public string telefonosContacto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empresas_Sucursales> Empresas_Sucursales { get; set; }
        public virtual TiposComercios TiposComercios { get; set; }
        public virtual ven_Municipios ven_Municipios { get; set; }
        public virtual ven_Parroquias ven_Parroquias { get; set; }
        public virtual world_Idiomas world_Idiomas { get; set; }
        public virtual world_Localidades world_Localidades { get; set; }
        public virtual world_Paises world_Paises { get; set; }
    }
}
