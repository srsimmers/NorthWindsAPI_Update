

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq; 
using Microsoft.EntityFrameworkCore;
using NorthWindsAPI_Update.Models;

namespace NorthWindsAPI_Update.Data

{
    public class Northwind : DbContext
    {
        public Northwind(DbContextOptions<Northwind> options) : base(options)
        {

        }

        public DbSet<Products_Data> Products { get; set; }
        public DbSet<Cust_Model> Cust_Model { get; set; }
    }
}
