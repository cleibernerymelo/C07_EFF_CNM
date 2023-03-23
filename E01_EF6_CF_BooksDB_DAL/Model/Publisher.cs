using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_EF6_CF_BooksDB_DAL.Model
{
    public partial class Publisher
    {
        // tabela 1
        #region Scalar properties
        public int PublisherID { get; set; }
        public string Name { get; set; }
        #endregion

        #region Navigation properties
        public virtual ICollection<Book> Books { get; set; }
        #endregion
    }
}
