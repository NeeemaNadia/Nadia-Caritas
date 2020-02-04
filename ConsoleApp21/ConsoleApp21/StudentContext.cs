using System;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp21
{
    public class StudentContext:DbContext
    {
        /*private readonly string _connectionString;

        public StudentContext(string connectionString)
        {
            _connectionString = connectionString;
        }*/
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*base.OnConfiguring(optionsBuilder);*/
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\WAKA\RiderProjects\ConsoleApp21\ConsoleApp21\StudentDB.db");
            
        }
    }
}