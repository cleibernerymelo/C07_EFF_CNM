﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D02_EF6_CF_V1.Model
{
    public partial class Post
    {
        // tabela 2
        #region Scalar properties
        public int PostId { get; set; } //PK
        public int BlogId { get; set; } //FK
        public string Title { get; set; }
        public string Content { get; set; }
        #endregion

        #region Navigation properties
        public virtual Blog Blog { get; set; }
        #endregion
    }
}
