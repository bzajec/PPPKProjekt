//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPPK_Servis
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vozilo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vozilo()
        {
            this.PutniNalogs = new HashSet<PutniNalog>();
            this.Servis = new HashSet<Servi>();
        }
    
        public int IDVozilo { get; set; }
        public string TipVozila { get; set; }
        public string MarkaVozila { get; set; }
        public int GodinaProizvodnje { get; set; }
        public int InicijalnoStanjeKilometara { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PutniNalog> PutniNalogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servi> Servis { get; set; }
    }
}