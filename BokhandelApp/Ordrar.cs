

namespace BokhandelApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ordrar
    {
        public int ID { get; set; }
        public Nullable<int> KundID { get; set; }
        public string ISBN { get; set; }
        public Nullable<int> Antal { get; set; }
        public Nullable<System.DateTime> Orderdatum { get; set; }
    
        public virtual Böcker Böcker { get; set; }
        public virtual Kunder Kunder { get; set; }
    }
}
