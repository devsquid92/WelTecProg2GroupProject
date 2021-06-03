using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

            anu.Show();
        }

        void addNewUserFormClosed(object sender, FormClosedEventArgs e)
        {
            var path = @"C:\Users\jmram\source\repos\WelTecProg2GroupProject\LibraryMgmWinForm\LibraryMgmWinForm\datafiles\Users.csv";

            if (Program.newUserId != null)
            {
                string[] nextline = new string[]
                     {
                        string.Format("{0},{1},{2},{3},{4}", Program.newUserId, Program.newUserLName,
                        Program.newUserFName, Program.newUserDept, Program.newUserIssItems)
                     };

                File.AppendAllLines(path, nextline);
            }

            Program.newUserId = null;
            displayUserInUserListBox();
        }
    }
}
