namespace Example_MVC.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ItemContext : DbContext
    {
        public ItemContext()
            : base("name=ItemContext")
        {
        }

        public virtual DbSet<ItemList> ItemLists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemList>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);
        }
    }
}
