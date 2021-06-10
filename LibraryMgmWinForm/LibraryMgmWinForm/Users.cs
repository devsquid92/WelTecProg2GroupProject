using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgmWinForm
{
    class Users
    {
        private int id;
        private string firstName;
        private string lastName;
        private string department;
        private List<string> issueItems = new List<string>();

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Department { get => department; set => department = value; }

        public string issItems
        {
            set
            {
                StringBuilder sb = new StringBuilder(value);

                sb.Length--;
                sb.Remove(0, 1);

                string[] otherItems = sb.ToString().Split(';');
                issueItems = new List<string>(otherItems);
                issueItems.Sort();
            }
        }

        public List<string> IssueItems
        {
            get
            {
                issueItems.Sort();
                return issueItems;
            }
        }

    }
}
