//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirmElect.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Clave_Conting
    {
        public int IdEmpresa { get; set; }
        public decimal IdClave { get; set; }
        public bool Usado { get; set; }
        public System.DateTime Fecha_Trans { get; set; }
        public string ClaveContingencia { get; set; }
        public System.DateTime Fecha_Importacion { get; set; }
        public bool Estado { get; set; }
        public Nullable<int> IdAmbiente { get; set; }
    
        public virtual tb_Empresa tb_Empresa { get; set; }
    }
}