//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class SOLICITUD
    {
        public decimal ID_SOLICITUD { get; set; }
        public decimal DURACION_PROGRAMA { get; set; }
        public string ESTADO { get; set; }
        public System.DateTime FECHA_SOLICITUD { get; set; }
        public decimal ID_ALUMNO { get; set; }
        public decimal ID_ANFITRION { get; set; }
        public decimal ID_ESTABLECIMIENTO { get; set; }
        public decimal ID_PROGRAMA { get; set; }
    
        public virtual ALUMNO ALUMNO { get; set; }
        public virtual ANFITRION ANFITRION { get; set; }
        public virtual ESTABLECIMIENTO ESTABLECIMIENTO { get; set; }
        public virtual PROGRAMA PROGRAMA { get; set; }
    }
}
