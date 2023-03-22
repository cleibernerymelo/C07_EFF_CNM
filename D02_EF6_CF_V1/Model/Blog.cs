﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_EF6_CF_V1.Model
{
    public partial class Blog
    {
        // tabela 1
        #region Scalar properties
        public int BlogId { get; set; }
        public string Name { get; set; }

        #endregion

        #region Navigation properties
        public virtual ICollection<Post> Posts { get;set; }
       // public virtual List<Post> Posts { get; set; }
        #endregion
    }
}
