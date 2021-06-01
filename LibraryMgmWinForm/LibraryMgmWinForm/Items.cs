using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgmWinForm
{
    class Items
    {
        private string isbn;
        private string title;
        private string author;
        private int yearPublished;


        // to do: this field does not belong here, should be transfered to Student class.
        //private List<string> issuedItems = new List<string>();

        public string Isbn { get => isbn; set => isbn = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public int YearPublished { get => yearPublished; set => yearPublished = value; }



        //to do: same with this functions, associated with the line above. "issuedItems"
        //public string issItems
        //{
        //    set
        //    {
        //        StringBuilder sb = new StringBuilder(value);
        //        sb.Length--;
        //        sb.Remove(0,1);

        //        string[] otheritems = sb.ToString().Split(';');
        //        issuedItems = new List<string>(otheritems);
        //        issuedItems.Sort();
        //    }
        //}

        //public List<string> IssuedItems
        //{
        //    get
        //    {
        //        issuedItems.Sort();
        //        return issuedItems;
        //    }
        //}
    }
}
