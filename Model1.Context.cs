//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeloitteCS
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DocumentEntities2 : DbContext
    {
        public DocumentEntities2()
            : base("name=DocumentEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DocumentInformation> DocumentInformation { get; set; }
        public virtual DbSet<User> User { get; set; }

        public System.Data.Entity.DbSet<DeloitteCS.Models.Membership> Memberships { get; set; }
    }
}
