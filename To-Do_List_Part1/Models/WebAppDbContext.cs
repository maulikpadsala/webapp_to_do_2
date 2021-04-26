using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace To_Do_List_Part1.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class WebAppDbContext : DbContext
    {
        public static DbSet<to_do_task> Tasks { get; set; }
        public WebAppDbContext()
           //Reference the name of your connection string ( WebAppCon )  
           : base("WebAppCon") { }
    }
}
