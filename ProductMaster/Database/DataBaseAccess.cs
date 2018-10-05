using ProductMaster.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaster.Database
{
    public class DataBaseAccess : DbContext
    {
        public DataBaseAccess() : base("myConnection") { }
        public DbSet<Categories> CategoriesDbSet { get; set; }
    }
}
