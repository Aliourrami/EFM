//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFM_Reg_V2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Films
    {
        public Films()
        {
            this.Emprunts = new HashSet<Emprunts>();
        }
    
        public int CodeFilm { get; set; }
        public string TitOuv { get; set; }
        public string NomReal { get; set; }
        public string TypeSup { get; set; }
        public string Disponible { get; set; }
    
        public virtual ICollection<Emprunts> Emprunts { get; set; }
    }
}
