using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Utilisateur> Liste_Utilisateur { get; set; }

        public DbSet<Article> Liste_Article { get; set; }
    }
}
