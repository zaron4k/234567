using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class NonFictionBook: Book
    {
        private string subject;
        public string Subject
        {
            get;
            set;
        }
        public NonFictionBook (string title, string author, string subject, int year, int price)
        {
            this.Subject = subject;
        }
    }
}
