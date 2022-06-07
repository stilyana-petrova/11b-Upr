using FirmDb.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirmDb.Data
{
    public class EmployeeContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-G29VUF0\SQLEXPRESS;Database=FirmDb;Integrated Security=true");
            }
        }
    }
}
