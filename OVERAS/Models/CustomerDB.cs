using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OVERAS.Models;
namespace OVERAS.Models
{
    public class CustomerDB : DbContext
    {
        public CustomerDB(DbContextOptions<CustomerDB> options) : base(options)
        {
        }
              public DbSet<customert>customertb12 { get; set; }
    }


}

