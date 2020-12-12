using Lab4_PhoneBook.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_PhoneBook.Context
{
    public class ProjectContext:DbContext
    {


        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=DESKTOP-2A32802\SQLEXPRESS01;Database=PhoneNumber;Integrated Security=True;";
        }
    
    
        public DbSet<Users> Userss { get; set; }
        
    
    }
}
