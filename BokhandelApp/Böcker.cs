

namespace BokhandelApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Böcker
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Böcker()
        {
            this.LagerSaldo = new HashSet<LagerSaldo>();
            this.Ordrar = new HashSet<Ordrar>();
        }
    
        public string ISBN { get; set; }
        public string Titel { get; set; }
        public string Språk { get; set; }
        public Nullable<decimal> Pris { get; set; }
        public Nullable<System.DateTime> Utgivningsdatum { get; set; }
        public Nullable<int> FörfattarID { get; set; }
    
        public virtual Författare Författare { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LagerSaldo> LagerSaldo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ordrar> Ordrar { get; set; }
    }
}
