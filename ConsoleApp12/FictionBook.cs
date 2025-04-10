using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class FictionBook : Book
    {
        private string genre;
        public string Genre 
            { get; set; }
        public FictionBook (string title, string author, string genre, int year, int price)
            {
            this.Genre = genre;
        }
    }
}
