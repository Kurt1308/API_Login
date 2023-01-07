using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;


namespace Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }
        public DbSet<authacesso> authacesso { get; set; }
        public DbSet<authconfigemail> authconfigemail { get; set; }
        public DbSet<authgrupo> authgrupo { get; set; }
        public DbSet<authgrupoxacesso> authgrupoxacesso { get; set; }
        public DbSet<authusuario> authusuario { get; set; }

    }
}
