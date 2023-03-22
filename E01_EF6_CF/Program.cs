using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;
using E01_EF6_CF.Model;

namespace E01_EF6_CF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            publisher.CreatePublisher();
            publisher.ReadPublisher();

            Book book = new Book();
            book.CreateBook();
            book.ReadBook();

            Utility.TerminateConsole();
        }
    }
}
