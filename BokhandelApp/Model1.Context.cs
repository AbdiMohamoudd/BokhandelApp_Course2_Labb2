

namespace BokhandelApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BokhandelEntities : DbContext
    {
        public BokhandelEntities()
            : base("name=BokhandelEntities") { }
    
        public virtual DbSet<Butiker> Butiker { get; set; }
        public virtual DbSet<Böcker> Böcker { get; set; }
        public virtual DbSet<Författare> Författare { get; set; }
        public virtual DbSet<Kunder> Kunder { get; set; }
        public virtual DbSet<LagerSaldo> LagerSaldo { get; set; }
        public virtual DbSet<Ordrar> Ordrar { get; set; }
    }
}
