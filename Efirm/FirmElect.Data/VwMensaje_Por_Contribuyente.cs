//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirmElect.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class VwMensaje_Por_Contribuyente
    {
        public decimal IdMensaje { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Para { get; set; }
        public string Asunto { get; set; }
        public string Asunto_texto_mostrado { get; set; }
        public int Tiene_Adjunto { get; set; }
        public int Prioridad { get; set; }
        public int Leido { get; set; }
        public bool Respondido { get; set; }
        public bool No_Leido { get; set; }
        public string Texto_mensaje { get; set; }
        public string IdTipo_Mensaje { get; set; }
        public string Carpeta_Mensaje { get; set; }
        public bool Eliminado { get; set; }
        public decimal IdContribuyente { get; set; }
        public int IdEmpresa { get; set; }
        public string cedulaRuc_contri { get; set; }
        public string Nom_Contribuyente { get; set; }
        public string Mail { get; set; }
        public string Mail_secundario { get; set; }
        public bool EsCliente { get; set; }
        public bool EsProveedor { get; set; }
        public string Password { get; set; }
        public bool Estado { get; set; }
        public string Observacion { get; set; }
        public string TipoContacto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
