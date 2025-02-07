

namespace BokhandelApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Författare
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Författare()
        {
            this.Böcker = new HashSet<Böcker>();
        }
    
        public int ID { get; set; }
        public string Förnamn { get; set; }
        public string Efternamn { get; set; }
        public Nullable<System.DateTime> Födelsedatum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Böcker> Böcker { get; set; }
    }
}
