using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMgmWinForm
{
    public partial class Form2 : Form
    {
        SortedDictionary<string, Users> userInfo = new SortedDictionary<string, Users>();
        static string[] headings = new string[5];

        Users selectedUser = new Users();

        public Form2()
        {
            InitializeComponent();
            var path = @"C:\Users\jmram\source\repos\WelTecProg2GroupProject\LibraryMgmWinForm\LibraryMgmWinForm\datafiles\Users.csv";

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                if (line.StartsWith("ID"))
                    headings = line.Split(',');

                else
                {
                    string[] info = line.Split(',');



                    userInfo.Add(string.Format("{0} , {1}", info[0], info[1]), new Users
                    {
                        Id = Int32.Parse(info[0]),
                        LastName = info[1],
                        FirstName = info[2],
                        Department = info[3],
                        issItems = info[4]

                    });

                }
            }

            refreshForm();
        }

        private void refreshForm()
        {
            displayUserInUserListBox();
        }

        private void displayUserInUserListBox()
        {

            stdntListBox.DataSource = new BindingSource(userInfo, null);
            stdntListBox.ValueMember = "Key";
        }

        private void stdntListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
