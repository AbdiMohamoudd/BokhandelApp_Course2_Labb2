
namespace BokhandelApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class LagerSaldo
    {
        public int ButikID { get; set; }
        public string ISBN { get; set; }
        public Nullable<int> Antal { get; set; }
    
        public virtual Butiker Butiker { get; set; }
        public virtual Böcker Böcker { get; set; }
    }
}
