//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Seccao
    {
        public string sect_sigla { get; set; }
        public string dpt { get; set; }
        public string coordenador { get; set; }
        public string sect_desc { get; set; }
    
        public virtual Departamento Departamento { get; set; }
        public virtual Professor Professor { get; set; }
    }
}
