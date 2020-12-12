using Lab3_CodeFirst_Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_CodeFirst_Library.Context
{
   public class ContextProject:DbContext
    {
        public ContextProject()
        {
            Database.Connection.ConnectionString = @"Server=DESKTOP-2A32802\SQLEXPRESS01;Database=LibraryProjectDbCode;Integrated Security=True;";
        }

        public DbSet <Categories> Categoriess { get; set; }
        public DbSet <Customers> Customerss { get; set; }
        public DbSet<Employees> Employeess;
        public DbSet<OrderDetails> OrdersDetailss;
        public DbSet<Orders> Orderss;
        public DbSet <Products> Productss;
        public DbSet<Shippers> Shipperss;
        public DbSet<Shippers> Shippers;
        





    }
}
