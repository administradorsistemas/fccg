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
    
    public partial class tb_Actividades_Horario
    {
        public tb_Actividades_Horario()
        {
            this.tb_Actividades_Horario_Acciones = new HashSet<tb_Actividades_Horario_Acciones>();
        }
    
        public string IdTransaccion { get; set; }
        public string IdTipoEjecucion { get; set; }
        public int Num_cbtes_x_pagina { get; set; }
        public bool lunes { get; set; }
        public bool martes { get; set; }
        public bool miercoles { get; set; }
        public bool jueves { get; set; }
        public bool viernes { get; set; }
        public bool sabado { get; set; }
        public bool domingo { get; set; }
        public bool ocurre_1_vez { get; set; }
        public System.TimeSpan valor_ocurre_1_vez { get; set; }
        public bool ocurre_cada { get; set; }
        public int valor_ocurre_cada { get; set; }
        public string IdTipoTiempo { get; set; }
        public System.TimeSpan hora_inicia_a_las { get; set; }
        public System.TimeSpan hora_finaliza_a_las { get; set; }
    
        public virtual ICollection<tb_Actividades_Horario_Acciones> tb_Actividades_Horario_Acciones { get; set; }
        public virtual tb_Actividades_Horario_Tipo_Ejecucion tb_Actividades_Horario_Tipo_Ejecucion { get; set; }
        public virtual tb_Actividades_Horario_Tipo_Tiempo tb_Actividades_Horario_Tipo_Tiempo { get; set; }
    }
}
