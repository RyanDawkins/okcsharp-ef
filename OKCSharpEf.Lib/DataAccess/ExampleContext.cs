using Microsoft.EntityFrameworkCore;
using OKCSharpEf.Lib.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace OKCSharpEf.Lib.DataAccess
{
    public class ExampleContext : DbContext
    {
        public ExampleContext(DbContextOptions<DbContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}
