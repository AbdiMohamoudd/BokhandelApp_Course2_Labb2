
namespace BokhandelApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Butiker
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Butiker()
        {
            this.LagerSaldo = new HashSet<LagerSaldo>();
        }
    
        public int ID { get; set; }
        public string Namn { get; set; }
        public string Adress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LagerSaldo> LagerSaldo { get; set; }
    }
}
