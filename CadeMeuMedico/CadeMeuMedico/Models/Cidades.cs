//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CadeMeuMedico.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cidades
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cidades()
        {
            this.Medicos = new HashSet<Medicos>();
        }
    
        public int IDCidade { get; set; }
        public string Nome { get; set; }
        public Nullable<int> IDEstado { get; set; }
    
        public virtual Estados Estados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medicos> Medicos { get; set; }
    }
}
