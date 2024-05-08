﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class kssERPSucursaldbEntities : DbContext
    {
        public kssERPSucursaldbEntities()
            : base("name=kssERPSucursaldbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Almacenes> Almacenes { get; set; }
        public virtual DbSet<Bancos> Bancos { get; set; }
        public virtual DbSet<Cajas> Cajas { get; set; }
        public virtual DbSet<Cajas_Cortes> Cajas_Cortes { get; set; }
        public virtual DbSet<Cajas_Cortes_IF> Cajas_Cortes_IF { get; set; }
        public virtual DbSet<Cajas_Egresos> Cajas_Egresos { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<Empresas_Sucursales> Empresas_Sucursales { get; set; }
        public virtual DbSet<Estaciones> Estaciones { get; set; }
        public virtual DbSet<Estaciones_Dipositivo_VisorPrecios> Estaciones_Dipositivo_VisorPrecios { get; set; }
        public virtual DbSet<Estaciones_Dispositivo_Balanza> Estaciones_Dispositivo_Balanza { get; set; }
        public virtual DbSet<Estaciones_Dispositivo_Firma> Estaciones_Dispositivo_Firma { get; set; }
        public virtual DbSet<Estaciones_Dispositivo_GavetaDinero> Estaciones_Dispositivo_GavetaDinero { get; set; }
        public virtual DbSet<Estaciones_Dispositivo_Impresora> Estaciones_Dispositivo_Impresora { get; set; }
        public virtual DbSet<Estaciones_Reportes> Estaciones_Reportes { get; set; }
        public virtual DbSet<Estaciones_Sesiones> Estaciones_Sesiones { get; set; }
        public virtual DbSet<Estaciones_Sesiones_Detalle> Estaciones_Sesiones_Detalle { get; set; }
        public virtual DbSet<Facturas> Facturas { get; set; }
        public virtual DbSet<Facturas_Descuentos> Facturas_Descuentos { get; set; }
        public virtual DbSet<Facturas_Detalle> Facturas_Detalle { get; set; }
        public virtual DbSet<Facturas_Detalle_Descuentos> Facturas_Detalle_Descuentos { get; set; }
        public virtual DbSet<Facturas_Detalle_Impuestos> Facturas_Detalle_Impuestos { get; set; }
        public virtual DbSet<Facturas_IF> Facturas_IF { get; set; }
        public virtual DbSet<Facturas_Impuestos> Facturas_Impuestos { get; set; }
        public virtual DbSet<Facturas_Modificadas> Facturas_Modificadas { get; set; }
        public virtual DbSet<Facturas_Modificadas_IF> Facturas_Modificadas_IF { get; set; }
        public virtual DbSet<Facturas_Servicios> Facturas_Servicios { get; set; }
        public virtual DbSet<Facturas_TiposPago> Facturas_TiposPago { get; set; }
        public virtual DbSet<Grupo_Usuarios> Grupo_Usuarios { get; set; }
        public virtual DbSet<Licencias> Licencias { get; set; }
        public virtual DbSet<Modulos> Modulos { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Productos_Calzado> Productos_Calzado { get; set; }
        public virtual DbSet<Productos_Compuestos> Productos_Compuestos { get; set; }
        public virtual DbSet<Productos_Familias> Productos_Familias { get; set; }
        public virtual DbSet<Productos_Farmacia> Productos_Farmacia { get; set; }
        public virtual DbSet<Productos_Impuestos> Productos_Impuestos { get; set; }
        public virtual DbSet<Productos_Marcas> Productos_Marcas { get; set; }
        public virtual DbSet<Productos_Supermercado> Productos_Supermercado { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TiposComercios> TiposComercios { get; set; }
        public virtual DbSet<TiposDescuento> TiposDescuento { get; set; }
        public virtual DbSet<TiposEgreso_Caja> TiposEgreso_Caja { get; set; }
        public virtual DbSet<TiposImpuestos> TiposImpuestos { get; set; }
        public virtual DbSet<TiposPago> TiposPago { get; set; }
        public virtual DbSet<TiposPago_Doc> TiposPago_Doc { get; set; }
        public virtual DbSet<TiposProducto> TiposProducto { get; set; }
        public virtual DbSet<TiposUnidadesMedida> TiposUnidadesMedida { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<Usuarios_detalle> Usuarios_detalle { get; set; }
        public virtual DbSet<Usuarios_roles> Usuarios_roles { get; set; }
        public virtual DbSet<Usuarios_rolesModulo> Usuarios_rolesModulo { get; set; }
        public virtual DbSet<ven_Municipios> ven_Municipios { get; set; }
        public virtual DbSet<ven_Parroquias> ven_Parroquias { get; set; }
        public virtual DbSet<world_Idiomas> world_Idiomas { get; set; }
        public virtual DbSet<world_Localidades> world_Localidades { get; set; }
        public virtual DbSet<world_Paises> world_Paises { get; set; }
        public virtual DbSet<world_Profesiones> world_Profesiones { get; set; }
        public virtual DbSet<world_Regiones> world_Regiones { get; set; }
        public virtual DbSet<world_UnidadesMedida> world_UnidadesMedida { get; set; }
        public virtual DbSet<Estaciones_Reportes_hoteles> Estaciones_Reportes_hoteles { get; set; }
    }
}