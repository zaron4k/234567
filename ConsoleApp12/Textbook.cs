using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Textbook : Book
    {
        private int grade_level;
        public int Grade_level
        {
            get;
            set;
        }
        public Textbook(string title, string author, int grade_level, int year, int price)
        {
            this.Grade_level = grade_level;
        }
    }
}
