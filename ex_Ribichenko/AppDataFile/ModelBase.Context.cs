﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ex_Ribichenko.AppDataFile
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RibichenkoEntities : DbContext
    {
        private static RibichenkoEntities _context;
        public RibichenkoEntities()
            : base("name=RibichenkoEntities")
        {
        }

        public static RibichenkoEntities GetContext()
        {
            if (_context == null)
            {
                _context = new RibichenkoEntities();
            }
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<country> country { get; set; }
        public virtual DbSet<@event> @event { get; set; }
        public virtual DbSet<jury> jury { get; set; }
        public virtual DbSet<member> member { get; set; }
        public virtual DbSet<moderator> moderator { get; set; }
        public virtual DbSet<organizer> organizer { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
