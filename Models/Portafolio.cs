//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Portafolio
    {
        public int IdPortafolio { get; set; }
        public int IdDocente { get; set; }
        public string Semestre { get; set; }
        public string NombreDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public byte[] Documento { get; set; }
    
        public virtual Docente Docente { get; set; }
    }
}
