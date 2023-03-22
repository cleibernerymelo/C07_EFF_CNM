using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_EF6_CF.Model
{
    public class BookContext : DbContext
    {
        #region Constructor (connectionstring do App.Config)
        public BookContext() : base("name=BooksDB")
        {

        }
        #endregion

        #region Criação da bd
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Desativar a pluralização das tabelas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        #endregion

        #region Tabelas em memórias (dbsets)
        public DbSet<Book> Book { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        #endregion
    }
}
