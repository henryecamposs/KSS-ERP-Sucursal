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
    
    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            this.Cajas_Egresos = new HashSet<Cajas_Egresos>();
            this.Estaciones_Sesiones = new HashSet<Estaciones_Sesiones>();
            this.Usuarios_detalle = new HashSet<Usuarios_detalle>();
            this.Usuarios_roles = new HashSet<Usuarios_roles>();
            this.Usuarios_rolesModulo = new HashSet<Usuarios_rolesModulo>();
        }
    
        public short id_Usuarios { get; set; }
        public Nullable<short> id_Empleados { get; set; }
        public short id_grupo_usuarios { get; set; }
        public short id_DefNivelAccesos { get; set; }
        public Nullable<bool> esActivo { get; set; }
        public Nullable<bool> esCaduca { get; set; }
        public Nullable<bool> esLogged { get; set; }
        public Nullable<System.DateTime> fecha_caduca { get; set; }
        public Nullable<System.DateTime> fecha_fin { get; set; }
        public Nullable<System.DateTime> fecha_inicio { get; set; }
        public string password { get; set; }
        public string usuario { get; set; }
        public short id_Empresas_Sucursales { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cajas_Egresos> Cajas_Egresos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estaciones_Sesiones> Estaciones_Sesiones { get; set; }
        public virtual Grupo_Usuarios Grupo_Usuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuarios_detalle> Usuarios_detalle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuarios_roles> Usuarios_roles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuarios_rolesModulo> Usuarios_rolesModulo { get; set; }
    }
}
