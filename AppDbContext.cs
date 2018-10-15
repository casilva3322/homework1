using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;



namespace BUFFTEKS
{
    public class AppDbContext : DbContext
    {
     
        private const string ConnectionString = @"Data Source=Bufftekss.db";

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            //Using the SQLite database provider’s UseSqlServer command sets up the options ready for creating the applications’s DBContext
            optionsBuilder.UseSqlite(ConnectionString); //#B
        }        

        public DbSet<Student> Students { get; set; }    
        public DbSet<Advisor> Advisors {get;set;}    
        public DbSet<Client> Clients{get;set;}
        public DbSet<Organization> Organizations {get;set;}
        public DbSet<Project> Projects {get;set;}
        public DbSet<Team> Teams {get;set;}
    }    
}