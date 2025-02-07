

namespace BokhandelApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kunder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kunder()
        {
            this.Ordrar = new HashSet<Ordrar>();
        }
    
        public int ID { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public string Epost { get; set; }
        public string Telefon { get; set; }
        public string Adress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ordrar> Ordrar { get; set; }
    }
}
