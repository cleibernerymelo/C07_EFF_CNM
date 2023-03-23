using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_EF6_CF_BooksDB_DAL.Model
{
    public partial class Book
    {
        // tabela 1
        #region Scalar properties
        public int BookID { get; set; }
        public int PublisherID { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }

        #endregion

        #region Navigation properties
        public virtual Publisher Publisher { get; set; }
        // public virtual List<Post> Posts { get; set; }
        #endregion
    }
}
