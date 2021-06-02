using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMgmWinForm
{
    public partial class UserReport : Form
    {
        SortedDictionary<string, Users> userInfo = new SortedDictionary<string, Users>();
        static string[] headings = new string[5];

        Users selectedUser = new Users();

        public UserReport()
        {
            InitializeComponent();


            // change path
            var path = @"../../datafiles/Users.csv";

            string[] lines = System.IO.File.ReadAllLines(path);

            foreach(string line in lines)
            {
                if (line.StartsWith("ID"))
                    headings = line.Split(',');

                else
                {
                    string[] info = line.Split(',');

                    userInfo.Add(info[0], new Users
                    {
                        FirstName = info[1],
                        LastName = info[2],
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

            userMgmtListBox.DataSource = new BindingSource(userInfo, null);
            userMgmtListBox.ValueMember = "Key";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void userMgmtListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userInfo.ContainsKey(userMgmtListBox.SelectedValue.ToString()))
                selectedUser = userInfo[userMgmtListBox.SelectedValue.ToString()];

            // must do: When 'View' button is click with selected user, pass data to Form4 'User Info'
        }

        private void addNewUserMgmButton_Click(object sender, EventArgs e)
        {
            addNewUser anu = new addNewUser();
            anu.FormClosed += new FormClosedEventHandler(addNewUserFormClosed);
        }

        void addNewUserFormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.newUserId != null)
                userInfo.Add(Program.newUserId, new Users
                {
                    FirstName = Program.newUserFName,
                    LastName = Program.newUserLName,
                    Department = Program.newUserDept,
                    issItems = "[none]"
                });

            Program.newUserId = null;
            displayUserInUserListBox();
        }
    }
}
