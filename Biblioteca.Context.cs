﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BibliotecaN
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BibliotecaEntities : DbContext
    {
        public BibliotecaEntities()
            : base("name=BibliotecaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Person> People { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Domain> Domains { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Lend> Lends { get; set; }
    }
}
