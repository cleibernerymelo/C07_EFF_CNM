using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace E01_EF6_CF.Model
{
    public partial class Publisher
    {
        public void CreatePublisher()
        {
            var db = new BookContext();

            using (db)
            {
                Publisher publisher1 = new Publisher();
                Publisher publisher2 = new Publisher();

                publisher1.Name = "publisher1";
                publisher2.Name = "publisher2";

                db.Publisher.Add(publisher1);
                db.Publisher.Add(publisher2);

                db.SaveChanges();
            }
        }

        public void ReadPublisher()
        {
            var db = new BookContext();
            var queryPublisher = db.Publisher.Select(p => p).OrderBy(p => p.PublisherID);

            Utility.WriteTitle("Publisher");

            queryPublisher.ToList().ForEach(p => Console.WriteLine($"{p.PublisherID} - {p.Name}"));
        }
    }
}
