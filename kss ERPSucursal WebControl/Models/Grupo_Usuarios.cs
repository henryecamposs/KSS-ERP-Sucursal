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
    
    public partial class Grupo_Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Grupo_Usuarios()
        {
            this.Usuarios = new HashSet<Usuarios>();
        }
    
        public short id_Grupo_Usuarios { get; set; }
        public short id_DefTipoUsuarioNivel { get; set; }
        public string grupo_usuario { get; set; }
        public bool esroot { get; set; }
        public bool esActivo { get; set; }
        public bool esAgregar { get; set; }
        public bool esEliminar { get; set; }
        public bool esModificar { get; set; }
        public bool esAccesoremoto { get; set; }
        public bool esListar { get; set; }
        public short id_Empresas_Sucursales { get; set; }
    
        public virtual Empresas_Sucursales Empresas_Sucursales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
