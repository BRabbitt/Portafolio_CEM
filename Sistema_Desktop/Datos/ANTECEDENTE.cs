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
    
    public partial class ANTECEDENTE
    {
        public ANTECEDENTE()
        {
            this.ANFITRION_ANTECEDENTE = new HashSet<ANFITRION_ANTECEDENTE>();
            this.ALUMNO_ANTECEDENTE = new HashSet<ALUMNO_ANTECEDENTE>();
            this.PROGRAMA_ANTECEDENTE = new HashSet<PROGRAMA_ANTECEDENTE>();
        }
    
        public decimal ID_ANTECEDENTE { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<ANFITRION_ANTECEDENTE> ANFITRION_ANTECEDENTE { get; set; }
        public virtual ICollection<ALUMNO_ANTECEDENTE> ALUMNO_ANTECEDENTE { get; set; }
        public virtual ICollection<PROGRAMA_ANTECEDENTE> PROGRAMA_ANTECEDENTE { get; set; }
    }
}
