using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgmWinForm
{
    class Items
    {
        private string title;
        private string isbn;
        private string author;
        private int yearPublished;
        private string category;

        public string Title { get => title; set => title = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public string Author { get => author; set => author = value; }
        public int YearPublished { get => yearPublished; set => yearPublished = value; }
        public string Category { get => category; set => category = value; }

    }
}
