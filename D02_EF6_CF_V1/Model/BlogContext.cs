﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_EF6_CF_V1.Model
{
    public class BlogContext : DbContext
    {
        #region Constructor (connectionstring do App.Config)
        public BlogContext() : base("name=BlogEntities")
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
        public DbSet<Blog> Blog { get; set;}
        public DbSet<Post> Post { get; set;}
        #endregion
    }
}
