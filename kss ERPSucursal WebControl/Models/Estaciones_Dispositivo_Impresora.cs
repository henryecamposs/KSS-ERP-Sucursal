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
    
    public partial class Estaciones_Dispositivo_Impresora
    {
        public short id_Estaciones_Dispositivo_Impresora { get; set; }
        public short id_DefImpresoraModelo { get; set; }
        public short id_DefImpresoraVendor { get; set; }
        public Nullable<short> id_DefTipoImpresora { get; set; }
        public Nullable<short> id_Estaciones { get; set; }
        public string Encabezado1 { get; set; }
        public string Encabezado2 { get; set; }
        public string Encabezado3 { get; set; }
        public string Encabezado4 { get; set; }
        public string Encabezado5 { get; set; }
        public string Encabezado6 { get; set; }
        public Nullable<bool> esCommPort { get; set; }
        public Nullable<bool> esIFiscal { get; set; }
        public Nullable<bool> esImprimirDatosEmpresa { get; set; }
        public Nullable<bool> esImprimirEmpleado { get; set; }
        public Nullable<bool> esImprimirNropedido { get; set; }
        public Nullable<bool> esMsjPiePagina { get; set; }
        public Nullable<bool> esNConsumo { get; set; }
        public Nullable<bool> esRemoto { get; set; }
        public Nullable<bool> esUsaSpooler { get; set; }
        public Nullable<byte> nColumnas { get; set; }
        public bool Nconsumo_esForzarImpresion { get; set; }
        public bool Nconsumo_esImpEncabezado { get; set; }
        public bool Nconsumo_esImpNombreEmpleado { get; set; }
        public bool Nconsumo_esImpopcionPropina { get; set; }
        public bool Nconsumo_esImpPieCliente { get; set; }
        public bool Nconsumo_esImpPrecios { get; set; }
        public bool Nconsumo_esImpPreciosConIVA { get; set; }
        public bool Nconsumo_esImpTotalConIVA { get; set; }
        public bool Nconsumo_MsjPiePagina { get; set; }
        public Nullable<byte> NConsumo_PuertoComunicaciones { get; set; }
        public string NombrePuerto { get; set; }
        public string PiePagina1 { get; set; }
        public string PiePagina2 { get; set; }
        public string PiePagina3 { get; set; }
        public string PiePagina4 { get; set; }
        public string PiePagina5 { get; set; }
        public string PiePagina6 { get; set; }
    }
}
