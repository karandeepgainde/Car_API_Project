using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Car_API_Project.Models;

namespace Car_API_Project.Data
{
    public class Car_API_ProjectContext : DbContext
    {
        public Car_API_ProjectContext (DbContextOptions<Car_API_ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<Car_API_Project.Models.Car> Car { get; set; }
    }
}
